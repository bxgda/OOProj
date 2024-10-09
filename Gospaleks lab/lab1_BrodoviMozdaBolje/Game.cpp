#include "Game.h"
#include <windows.h>
#include <iomanip>

Game* Game::game = nullptr;

Game::Game()
{
	player = nullptr;
	field = new Field();
	shipManager = new ShipManager(field);
}

void Game::init()
{
	// Init from files
	field->initField("polje.txt");
	player = new Player(field->getNumOfRows(), field->getNumOfCols());
	shipManager->initShips("brodovi.txt");
}

void Game::run()
{
	bool isHitted = false;
	bool sunked = false;
	int numberOfHits = 0;

	// Main game loop
	while (!isGameOver()) {
	
		// Make move
		Position pos = player->makeMove();

		// Apply move
		isHitted = shipManager->applyMove(pos, sunked);

		// If player hit a ship, update notes
		if (isHitted) {
			player->updateNotes(pos);
		}

		// Check if strategy is finished
		if (player->checkIsStrategyFinished(isHitted)) {

			// If strategy 1 is finished, set first hit for strategy 2
			if (player->getStrategy() == 0){
				player->firstHit = pos;
			}

			// If strategy 2 is finished, set second hit for strategy 3
			else if (player->getStrategy() == 1) {
				player->secondHit = pos;

				// Special situation when strategy 2 sunk the ship (ship is length 2)
				if (sunked) {
					player->changeStrategy();
				}
				else {
					// Sort the hits (this sets initial positions for Strategy 3)
					if (player->firstHit.row == player->secondHit.row) {
						if (player->firstHit.col > player->secondHit.col)
							std::swap(player->firstHit, player->secondHit);
					}

					else {
						if (player->firstHit.row > player->secondHit.row)
							std::swap(player->firstHit, player->secondHit);
					}
				}
			}


			player->changeStrategy();
		}

		++numberOfHits;

		// Show info for player
		system("cls");
		std::cout << std::left << std::setw(15) << "Strategy: " << player->getStrategy() + 1 << "\n";
		std::cout << std::left << std::setw(15) << "Player move: " << pos.row << " " << pos.col << "\n\n";
		if (isHitted) std::cout << "HIT!" << "\n\n";
		else std::cout << "MISS!" << "\n\n";
		player->showNotes();
		std::cout << "------------------------------" << std::endl;
		Sleep(200);
	}

	// Game over
	std::cout << "\n\nEnd of game. Map is:\n\n";
	field->showRealMatrix(*shipManager);
	std::cout << "Number of hits: " << numberOfHits << "\n";
}

bool Game::isGameOver()
{
	return shipManager->checkShips();
}

Game::~Game()
{
	delete field;
	delete player;
	delete shipManager;
}

void Game::setInstance()
{
	if (Game::game == nullptr)
		Game::game = new Game();
}

Game* Game::getInstance()
{
	return Game::game;
}

void Game::startGame()
{
	init();
	run();
}
