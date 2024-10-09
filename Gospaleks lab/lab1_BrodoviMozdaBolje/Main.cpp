#include "Game.h"

int main() {

	srand(time(NULL));

	Game* game;
	Game::setInstance();
	game = Game::getInstance();

	try {
		game->startGame();
	}
	catch (std::exception& e) {
		std::cout << e.what() << std::endl;
	}

	delete game;
}