#pragma once
#include <vector>
#include "Field.h"
#include "Position.h"

class Ship
{
private:

	Position startPos;			// start position of the ship
	Direction dir;				// 1 - horizontal, 0 - vertical

	std::vector<bool> parts;	// parts of the ship (true - alive, false - not alive)

	int len;
	bool isSunk;
	
public:
	
	Ship(int len, Position startPos, Direction dir);
	~Ship();

	Position getStartPos() const;
	int getLen() const;
	Direction getDirection() const;

	bool isSunked();
	void checkIsSunked();
	
	void hitPart(int index);
};

