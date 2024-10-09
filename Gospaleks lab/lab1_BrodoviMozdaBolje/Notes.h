#pragma once
#include <iostream>
#include "Position.h"

class Notes
{
private:
	char** playerMatrix;

	int numOfRows;
	int numOfCols;

public:
	Notes(int rows, int cols);
	~Notes();

	void update(Position pos);
	void showMatrix();
};

