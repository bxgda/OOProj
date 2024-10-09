#pragma once
#include "Ship.h"
#include "Position.h"

class Field;
class Ship;
class Position;

class ShipManager
{
private:

	std::vector<Ship * > ships;
	Field* field;

public:

	ShipManager(Field* field);
	~ShipManager();

	void initShips(const char* fileName);
	void setShipsPositionsOnMatrix(char** matrix);
	
	bool applyMove(Position pos, bool& sunked);

	bool checkShips();
	bool checkShipInput(int len, Position startPos, Direction direction);
};

