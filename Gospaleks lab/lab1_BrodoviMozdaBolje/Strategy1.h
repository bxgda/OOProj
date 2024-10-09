#pragma once
#include <cstdlib>
#include "Strategy.h"

class Strategy1 : public Strategy
{
private:
	int rowsMax;
	int colsMax;
public:

	Strategy1(int rowsMax, int colsMax);
	~Strategy1();

	virtual Position move();
	virtual bool isFinished(bool& isHitted);
};
