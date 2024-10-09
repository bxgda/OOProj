#include "Strategy1.h"

Strategy1::Strategy1(int rowsMax, int colsMax)
{
    this->rowsMax = rowsMax;
	this->colsMax = colsMax;
}

Strategy1::~Strategy1()
{
}

Position Strategy1::move()
{
	return Position(std::rand() % rowsMax, std::rand() % colsMax);
}

bool Strategy1::isFinished(bool& isHitted)
{
	return isHitted;
}
