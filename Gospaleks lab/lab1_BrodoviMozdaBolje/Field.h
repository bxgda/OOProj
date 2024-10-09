#pragma once
#include <iostream>
#include <fstream>
#include "ShipManager.h"
#include "Position.h"

class ShipManager;

class Field
{
private:

	char** matrix;

	int numOfRows;
	int numOfCols;

	void allocateMemory(int nr, int nc);
	void freeMemory();

public:
	Field();
	~Field();

	int getNumOfRows() const;
	int getNumOfCols() const;

	void initField(const char* fileName);

	void showRealMatrix(ShipManager& shipManager);

	bool checkIsShipOnLand(int len, Position startPos, Direction direction);
};

