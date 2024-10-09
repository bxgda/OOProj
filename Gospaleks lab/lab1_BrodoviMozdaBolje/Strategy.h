#pragma once
#include "Position.h"

class Strategy
{
public:
	Strategy() { }
	virtual ~Strategy() { }
	virtual Position move() = 0;	// generate position
	virtual bool isFinished(bool& isHitted) = 0;	// check if strategy achieved goal
};

