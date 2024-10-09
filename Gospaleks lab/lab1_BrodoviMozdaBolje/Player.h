#pragma once
#include "Strategy1.h"
#include "Strategy2.h"
#include "Strategy3.h"
#include "Position.h"
#include "Notes.h"
#include <vector>

class Player
{
private:

	int rowsMax;
	int colsMax;

	int currentStrategy;

	Notes* notes;

	Strategy* playerStrategy;

public:

	Position firstHit;
	Position secondHit;

	Player(int r, int c);
	~Player();

	Position makeMove();
	bool checkIsStrategyFinished(bool& isHitted);

	int getStrategy();
	void changeStrategy();

	void updateNotes(Position pos);
	void showNotes();
};

