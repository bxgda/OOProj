#pragma once
#include "FabrikaObjekata.h"
#include <windows.h>

class Livada;
class Mlaz;

class Igra
{
private:
	Livada* livada;
	Mlaz* mlaz;

	Igra();
	void igraj();
	bool krajIgre();
	void ucitaj();
	
	static Igra* igra;

	int poeni();
public:
	~Igra();
	
	static void napraviIgru();
	static Igra* vratiIgru();
	
	void pokreniIgru();

};

