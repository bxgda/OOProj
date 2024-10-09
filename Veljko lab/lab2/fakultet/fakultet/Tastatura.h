#pragma once
#include "Periferija.h"

enum Tip
{
	LATINICNA,
	CIRILICNA,
	ENGLESKA
};

class Tastatura : public Periferija
{
	Tip tipTastature;
public:
	Tastatura();
	Tastatura(Tip ttip);
	void ispisi();
};

