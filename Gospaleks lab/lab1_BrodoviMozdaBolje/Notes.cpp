#include "Notes.h"

Notes::Notes(int rows, int cols)
{
	numOfRows = rows;
	numOfCols = cols;

	//initialize the matrix for player (empty at start)
	playerMatrix = new char* [numOfRows];
	for (int i = 0; i < numOfRows; ++i)
		playerMatrix[i] = new char[numOfCols];

	for (int i = 0; i < numOfRows; ++i)
		for (int j = 0; j < numOfCols; j++)
			playerMatrix[i][j] = '.';
}

Notes::~Notes()
{
	if (playerMatrix != nullptr) {
		for (int i = 0; i < numOfRows; ++i)
			delete[] playerMatrix[i];
		delete[] playerMatrix;
	}
}

void Notes::update(Position pos)
{
	playerMatrix[pos.row][pos.col] = 'X';
}

void Notes::showMatrix()
{
	std::cout << "   ";
	for (int i = 0; i < numOfCols; ++i)
		std::cout << i << " ";
	std::cout << "\n";
	for (int i = 0; i < numOfRows; i++)
	{
		std::cout << i << "  ";
		for (int j = 0; j < numOfCols; j++)
			std::cout << playerMatrix[i][j] << " ";
		std::cout << std::endl;
	}
	std::cout << std::endl;
}
