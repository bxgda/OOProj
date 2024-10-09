#include "Player.h"

Player::Player(int r, int c) : rowsMax(r), colsMax(c)
{
	notes = new Notes(r, c);
	currentStrategy = 0;
	playerStrategy = new Strategy1(r, c);
}

Player::~Player()
{
	delete notes;
	delete playerStrategy;
}

Position Player::makeMove()
{
	return playerStrategy->move();
}

bool Player::checkIsStrategyFinished(bool& isHitted)
{
	return playerStrategy->isFinished(isHitted);
}

int Player::getStrategy()
{
	return currentStrategy;
}

void Player::changeStrategy()
{
	currentStrategy = (currentStrategy + 1) % 3;

	delete playerStrategy;
	if (currentStrategy == 0) {
		playerStrategy = new Strategy1(rowsMax, colsMax);
	}
	else if (currentStrategy == 1) {
		playerStrategy = new Strategy2(firstHit);
	}
	else {
		playerStrategy = new Strategy3(firstHit, secondHit);
	}
}

void Player::updateNotes(Position pos)
{
	notes->update(pos);
}

void Player::showNotes()
{
	notes->showMatrix();
}
