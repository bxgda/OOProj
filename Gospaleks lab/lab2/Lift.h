#pragma once
#include "Skijaliste.h"
#include "Skijas.h"
#include "Cetvorosed.h"
#include "Dvosed.h"
#include "Tanjir.h"

class Skijaliste;

enum TipLifta { CETVOROSED, DVOSED, TANJIR };

class Lift
{
private:
	Skijaliste* skijaliste;
	int kapacitet;
	std::string naziv;
	std::vector<Prikljucak*> nizPrikljucaka;
	TipLifta tip;

	// Vraca prikljucak sa prosledjenim id-em
	Prikljucak* vratiPrikljucak(int id);

	// Proveri dal je skijas vec u nekom prikljucku
	bool proveriSkijasa(int skiPas);

public:
	Lift(Skijaliste* skijaliste, std::string naziv, int kapacitet, TipLifta tip);
	~Lift();

	void dodaj(Prikljucak* p);
	bool izbaci(int id);
	Prikljucak* vratiNajveci();

	void smanjiKapacitet(int za);
	void povecajKapacitet(int za);

	void sacuvajStanje(std::string imeFajla);

	bool dodajSkijasa(Skijas* s, int id);
	std::vector<int> vratiListuSkiPasa(int id);

	void ispisi(std::ostream& izlaz);
};