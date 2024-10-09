#pragma once
#include "Field.h"
#include "ShipManager.h"
#include "Player.h"

class Game
{
private:
	
	Field* field;
	Player* player;
	ShipManager* shipManager;

	Game();

	void init();
	void run();
	bool isGameOver();

public:

	~Game();

	static Game* game;
	static void setInstance();
	static Game* getInstance();

	void startGame();
};

