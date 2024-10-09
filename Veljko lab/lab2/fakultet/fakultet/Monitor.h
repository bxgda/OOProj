#pragma once
#include "Periferija.h"

class Monitor : public Periferija
{
	float dijagonalaEkrana;
	string rezolucija;
	string marka;
public:
	Monitor();
	Monitor(float de, string rez, string mmarka);
	void ispisi();
};

