#include "Strategy2.h"

Strategy2::Strategy2(Position pos)
{
	this->pos = pos;
	curr = 0;
}

Strategy2::~Strategy2()
{
}

Position Strategy2::move()
{
	int drow[4] = { -1, 0, 1, 0 };
	int dcol[4] = { 0, 1, 0, -1 };

	Position next = Position(pos.row + drow[curr], pos.col + dcol[curr]);
	curr = (curr + 1) % 4;

	return next;
}

bool Strategy2::isFinished(bool& isHitted)
{
	return isHitted;
}
