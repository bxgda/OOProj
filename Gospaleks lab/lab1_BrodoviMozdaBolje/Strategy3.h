#pragma once
#include "Strategy.h"

class Strategy3 : public Strategy
{
private:
	Position fHit, sHit;
	bool goLeft, goTop;
	int misses;

public:
	Strategy3(Position fHit, Position sHit);
	~Strategy3();
	
	virtual Position move();
	virtual bool isFinished(bool& isHitted);
};

