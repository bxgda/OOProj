#pragma once
#include "Skijas.h"
#include <iomanip>
#include <fstream>
#include <iostream>

class Prikljucak
{
protected:
	int id;
	std::vector<Skijas*> skijasi;
	bool postavljen;
	int brojMesta;

public:
	Prikljucak(int id, int brojMesta);
	virtual ~Prikljucak();

	bool proveriSkijasa(int skiPas);
	void ukloniSkijasa(int skiPas);
	virtual void ispisi(std::ostream& izlaz) const = 0;
	virtual void dodajSkijasa(Skijas* s) = 0;

	virtual bool jeTezi(Prikljucak* p) = 0;
	virtual float vratiMasu() = 0;

	std::vector<int> vratiListuSkiPasa();
	bool vratiPostavljen() const { return postavljen; }
	int vratiId() const { return id; }
	void postavi() { postavljen = true; }
	void skloni() { postavljen = false; }
	int vratiBrojMesta() const { return brojMesta; }
};

