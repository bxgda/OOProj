#pragma once

enum class Direction {
	VERTICAL,
	HORIZONTAL
};

class Position
{
public:
	int row;
	int col;
	Position() : row(-1), col(-1) { }
	Position(int row, int col) : row(row), col(col) { }
};