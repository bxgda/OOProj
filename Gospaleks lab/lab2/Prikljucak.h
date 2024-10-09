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

	// Uklanja skijasa sa datim ski pasom
	void ukloniSkijasa(int skiPas);

	// Proverava dal je vec u prikljucku
	bool proveriSkijasa(int _skiPas);

	// Vraca listu skiPasa
	std::vector<int> vratiListuSkiPasa();

	// Getteri i setteri
	bool vratiPostavljen() const { return postavljen; }
	int vratiId() const { return id; }
	void postavi() { postavljen = true; }
	void skloni() { postavljen = false; }
	int vratiBrojMesta() const { return brojMesta; }

	// Virtual metode predefinisane u izvedenim klasama
	virtual float opterecenje() = 0;
	virtual void ispisi(std::ostream& izlaz) const = 0;
	virtual bool dodajSkijasa(Skijas* s) = 0;
};

