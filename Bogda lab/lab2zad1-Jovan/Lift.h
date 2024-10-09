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
	std::string naziv;
	std::vector<Prikljucak*> nizPrikljucaka;
	int kapacitet;
	TipLifta tip;

	bool proveriSkijasa(int skiPas);

public:
	Lift(Skijaliste* skijaliste, std::string naziv, int kapacitet, TipLifta tip);
	~Lift();

	void dodaj(Prikljucak* p);
	bool izbaci(int id);
	Prikljucak* vratiNajveci();

	void smanjiKapacitet(int za);
	void povecajKapacitet(int za);
	void ispisi(std::ostream& izlaz);
	void sacuvajStanje(std::string imeFajla);
	bool dodajSkijasa(Skijas* s, int id);

	std::vector<int> vratiListuSkiPasa(int id);
	Prikljucak* vratiPrikljucak(int id);
};