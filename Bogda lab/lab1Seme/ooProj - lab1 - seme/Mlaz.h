#pragma once
#include "Polja.h"
#include "Livada.h"

// ova struktura je tu da bi imali skroz 3  random pozicije
struct Pozicija {
	int pozRed;
	int pozKolona;
	Pozicija() {}
	Pozicija(int r, int k) : pozRed(r), pozKolona(k) { }
	bool operator==(const Pozicija& p) {
		return pozRed == p.pozRed && pozKolona == p.pozKolona;
	}
};

class Livada;

class Mlaz
{
private:
	int red;
	int kolona;
	int jacina;
	Livada* livada;
public:
	Mlaz(int red, int kolona, Livada* livada);
	int vratiJacinu() { return jacina; }
	int vratiRed() { return red; }
	int vratiKolonu() { return kolona; }

	void polijPolje();

	void ruzaSlucaj2();
	void ruzaSlucaj3();
	void ruzaSlucaj4();

	void jajeSlucaj2();
	void jajeSlucaj3();

	Pozicija* ruza4jaje3(TipPolja tip);

	void poruka(int slucaj);
};
