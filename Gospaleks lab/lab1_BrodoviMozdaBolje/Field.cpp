#pragma once
#include "Field.h"

void Field::allocateMemory(int nr, int nc)
{
	numOfRows = nr;
	numOfCols = nc;

	matrix = new char* [numOfRows];
	for (int i = 0; i < numOfRows; ++i)
		matrix[i] = new char[numOfCols];
}

void Field::freeMemory()
{
	if (matrix != nullptr) {
		for (int i = 0; i < numOfRows; ++i)
			delete[] matrix[i];
		delete[] matrix;
	}
}

Field::Field()
{
	matrix = nullptr;
	numOfRows = numOfCols = 0;
}

Field::~Field()
{
	freeMemory();
}

int Field::getNumOfRows() const { return numOfRows; }

int Field::getNumOfCols() const { return numOfCols; }

void Field::initField(const char* fileName)
{
	std::ifstream input(fileName);
	if (input.good()) {
		
		int nr, nc;
		input >> nr >> nc;

		allocateMemory(nr, nc);
		
		for (int i = 0; i < numOfRows; ++i) {
			for (int j = 0; j < numOfCols; j++) {

				char c;
				input >> c;

				matrix[i][j] = c;
			}
		}

	}
	else {
		throw std::exception("Error while reading field file.");
	}

	input.close();
}

void Field::showRealMatrix(ShipManager& shipManager)
{
	// Copy field matrix
	char** copyMatrix = new char* [numOfRows];
	for (int i = 0; i < numOfRows; ++i)
		copyMatrix[i] = new char[numOfCols];

	for (int i = 0; i < numOfRows; i++)
		for (int j = 0; j < numOfCols; j++)
			copyMatrix[i][j] = matrix[i][j];

	// Set ships positions on copy matrix
	shipManager.setShipsPositionsOnMatrix(copyMatrix);

	// Show copy matrix
	std::cout << "   ";
	for (int i = 0; i < numOfCols; ++i)
		std::cout << i << " ";
	std::cout << "\n";

	for (int i = 0; i < numOfRows; i++)
	{
		std::cout << i << "  ";
		for (int j = 0; j < numOfCols; j++)
			std::cout << copyMatrix[i][j] << " ";
		std::cout << std::endl;
	}
	std::cout << std::endl;

	// Free memory for copy matrix
	for (int i = 0; i < numOfRows; ++i)
		delete[] copyMatrix[i];
	delete[] copyMatrix;
}

bool Field::checkIsShipOnLand(int len, Position startPos, Direction direction)
{	
	for (int i = 0; i < len; ++i) {
		if (direction == Direction::HORIZONTAL) {
			if (matrix[startPos.row][startPos.col + i] == 'O')
				return true;
		}
		else {
			if (matrix[startPos.row + i][startPos.col] == 'O')
				return true;
		}
	}

	return false;
}
