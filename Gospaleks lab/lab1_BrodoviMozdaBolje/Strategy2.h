#pragma once
#include "Strategy.h"

class Strategy2 : public Strategy
{
private:
	int curr;
	Position pos;
public:
	
	Strategy2(Position pos);
	~Strategy2();

	virtual Position move();
	virtual bool isFinished(bool& isHitted);
};

