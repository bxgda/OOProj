#pragma once
#include "Ship.h"

Ship::Ship(int len, Position startPos, Direction direction)
{
	this->dir = direction;
	this->len = len;
	this->startPos = startPos;
	this->isSunk = false;
	this->parts.resize(len, true);
}

Ship::~Ship()
{
	parts.clear();
}

Position Ship::getStartPos() const
{
	return startPos;
}

int Ship::getLen() const
{
	return len;
}

Direction Ship::getDirection() const
{
	return dir;
}

bool Ship::isSunked()
{
	return isSunk;
}

void Ship::checkIsSunked()
{
	// if all parts are false, then ship is sunk
	for (bool part : parts)
		if (part == true)
			return;

	isSunk = true;
}

void Ship::hitPart(int index)
{
	if (index >= 0 && index < parts.size())
		parts[index] = false;
}
