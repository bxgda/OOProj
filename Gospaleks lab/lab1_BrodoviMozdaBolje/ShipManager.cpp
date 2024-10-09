#include "ShipManager.h"

ShipManager::ShipManager(Field * field)
{
	this->field = field;
}

ShipManager::~ShipManager()
{
	for (int i = 0; i < ships.size(); i++)
		delete ships[i];
	ships.clear();
}

void ShipManager::initShips(const char* fileName)
{
	std::ifstream input(fileName);				// file with ships	
	std::ofstream errors("losiBrodovi.txt");	// file for errors

	if (input.good()) {

		int n;
		input >> n;

		for (int i = 0; i < n; i++) {

			Position startPos;
			input >> startPos.row >> startPos.col;

			int len;
			input >> len;

			int direction;
			input >> direction;

			Direction dir = (direction == 1) ? Direction::HORIZONTAL : Direction::VERTICAL;
			
			// check if ship can be placed propery on the field
			if (checkShipInput(len, startPos, dir)) {
				ships.push_back(new Ship(len, startPos, dir));
			}
			else {
				errors << "Ship " << i + 1 << " can't be placed on the field." << std::endl;
			}
		}
	}
	else
		throw std::exception("Error while reading ships file.");

	input.close();
	errors.close();
}

// helper function for setting ships on provided matrix (just for end of game)
void ShipManager::setShipsPositionsOnMatrix(char** matrix)
{
	for (Ship* curShip : ships) {

		Position curPos = curShip->getStartPos();

		for (int i = 0; i < curShip->getLen(); i++) {					// for each position of ship
			matrix[curPos.row][curPos.col] = '0' + curShip->getLen();

			if (curShip->getDirection() == Direction::HORIZONTAL)
				curPos.col++;
			else
				curPos.row++;
		}
	}
}

bool ShipManager::applyMove(Position pos, bool& sunked)
{
	for (Ship * curShip : ships) {								// for each ship
		
		// If ship is already sunk, skip it
		if (curShip->isSunked())
			continue;

		Position curP = curShip->getStartPos();
		Direction curDir = curShip->getDirection();

		// hit is true if position is part of ship
		bool hit = false;

		// index is index of hitted part of ship
		int index = 0;

		// if ship row is the same as position row
		if (curP.row == pos.row) {
			if (curDir == Direction::HORIZONTAL) {
				// if ship is horizontal and position is in the range of ship
				if (pos.col >= curP.col && pos.col < curP.col + curShip->getLen()) {
					hit = true;
					index = pos.col - curP.col;
				}
			}
			else if (curDir == Direction::VERTICAL) {
				// if ship is vertical and rows are the same then check just columns
				if (pos.col == curP.col) {
					hit = true;
					index = pos.row - curP.row;
				}
			}
		}

		// if ship column is the same as position column (same logic)
		else if (curP.col == pos.col) {
			if (curDir == Direction::VERTICAL) {
				if (pos.row >= curP.row && pos.row < curP.row + curShip->getLen()) {
					hit = true;
					index = pos.row - curP.row;
				}
			}
			else if (curDir == Direction::HORIZONTAL) {
				if (pos.row == curP.row) {
					hit = true;
					index = pos.col - curP.col;
				}
			}
		}

		if (hit) {
			curShip->hitPart(index);

			// Sets sunk to true if all pieces of ship are hit
			curShip->checkIsSunked();

			sunked = curShip->isSunked();

			return true;
		}

	}

	sunked = false;
	return false;
}

bool ShipManager::checkShips()
{
	// If all ships are sunked, return true
	for (Ship * s : ships) {
		if (!s->isSunked())
			return false;
	}
	return true;
}

bool ShipManager::checkShipInput(int len, Position startPos, Direction direction)
{
	// Check is ship placed on the field properly (one positon away from edge)

	// check only first and last position of ship

	if (direction == Direction::HORIZONTAL) {	// horizontal
		if (startPos.row < 1 || startPos.row >= field->getNumOfRows() - 1 ||
			startPos.col < 1 || startPos.col + len - 1 >= field->getNumOfCols() - 1)
				return false;
	}
	else {										// vertical
		if (startPos.row < 1 || startPos.row + len - 1 >= field->getNumOfRows() - 1 ||
			startPos.col < 1 || startPos.col >= field->getNumOfCols() - 1)
				return false;
	}

	// Check if ship is not placed on another ship and one part away from every other ship
	for (Ship * curShip : ships)						// for each ship
	{
		Position curP = curShip->getStartPos();
		int curLen = curShip->getLen();
		Direction curDir = curShip->getDirection();

		if (direction == curDir) {						// if ships are in the same direction
			if (direction == Direction::HORIZONTAL) {
				if (abs(startPos.row - curP.row) <= 1 && startPos.col <= curP.col + curLen && startPos.col + len >= curP.col)
					return false;
			}
			else {
				if (abs(startPos.col - curP.col) <= 1 && startPos.row <= curP.row + curLen && startPos.row + len >= curP.row)
					return false;
			}
		}
		else {											// if ships are in different directions
			if (direction == Direction::HORIZONTAL) {
				if (startPos.row >= curP.row - 1 && startPos.row <= curP.row + curLen) {
				
					// right side of cur ship
					if (startPos.col == curP.col || startPos.col + 1 == curP.col)
						return false;

					// left side of cur ship
					if (startPos.col + len - 1 == curP.col || startPos.col + len == curP.col)
						return false;
				}
			}
			else {
				if (startPos.col >= curP.col - 1 && startPos.col <= curP.col + curLen) {

					// bottom side of cur ship
					if (startPos.row == curP.row || startPos.row - 1 == curP.row)
						return false;

					// top side of cur ship
					if (startPos.row + len - 1 == curP.row || startPos.row + len == curP.row)
						return false;

				}
			}
		}
	}

	// Check if ship is not placed on land in field
	if (field->checkIsShipOnLand(len, startPos, direction))
		return false;

	return true;
}
