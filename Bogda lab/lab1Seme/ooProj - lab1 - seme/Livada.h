#pragma once
#include "Polja.h"
#include "FabrikaObjekata.h"
#include <fstream>
#include <iostream>

class Polja;

class Livada
{
private:
	Polja*** mat;
	int n;
public:
	Livada();
	~Livada();
	void zauzmiMemoriju(int n);
	void ucitajLivadu(const char* imeFajla);
	int vratiN() { return n; }
	Polja** operator[](int i) { return mat[i]; }
	void ispisiLivadu(int red, int kolona);
	void ispisiSaSakrivenim();
	int izbrojiRuze();
	bool proveriKraj();
};

