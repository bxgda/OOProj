#pragma once
#include <iostream>
#include <cstdlib>

enum TipPolja {
	JAJE,
	SEME,
	TRAVA,
	TROJANSKIPUZ,
	TROJANSKARUZA,
	PUZ,
	RUZA
};

class Polja
{
protected:
	bool otkriveno;
	TipPolja tip;
public:
	Polja() { otkriveno = false; }
	bool vratiOtkriveno() { return otkriveno; }
	void postaviOtkriveno() { otkriveno = true; }
	TipPolja vratiTip() { return tip; }
	virtual int vratiKolicinu() = 0;
	void ispisiTip() {
		switch (tip)
		{
		case JAJE:
			std::cout << "J" << vratiKolicinu();
			break;
		case SEME:
			std::cout << "S" << vratiKolicinu();
			break;
		case TRAVA:
			std::cout << "! ";
			break;
		case TROJANSKIPUZ:
			std::cout << "TP";
			break;
		case TROJANSKARUZA:
			std::cout << "TR";
			break;
		case PUZ:
			std::cout << "P ";
			break;
		case RUZA:
			std::cout << "R ";
			break;
		}
	}
};

class Zametak :
	public Polja
{
protected:
	int kolicina;
public:
	Zametak() :Polja() {}
	Zametak(int kolicina) :Polja() {
		this->kolicina = kolicina;
	}
	int vratiKolicinu() { return kolicina; }
};

class Jaje :
	public Zametak
{
public:
	Jaje() :Zametak() {
		kolicina = 1;
		tip = JAJE;
	}
	int vratiKolicinu() { return kolicina; }
};

class Seme :
	public Zametak
{
public:
	Seme() :Zametak() {
		// kolicina se postavlja na slucajan nacin (1 ili 2)
		kolicina = std::rand() % 2 + 1;
		tip = SEME;
	}
	Seme(int kolicina) :Zametak(kolicina) {
		tip = SEME;
	}
	int vratiKolicinu() { return kolicina; }
};

class Puz :
	public Polja
{
public:
	Puz() :Polja() {
		tip = PUZ;
	}
	int vratiKolicinu() { return 0; }
};

class Ruza :
	public Polja
{
public:
	Ruza() :Polja() {
		tip = RUZA;
	}
	int vratiKolicinu() { return 0; }
};

class TrojanskaRuza :
	public Polja
{
public:
	TrojanskaRuza() :Polja() {
		tip = TROJANSKARUZA;
	}
	int vratiKolicinu() { return 0; }
};

class TrojanskiPuz :
	public Polja
{
public:
	TrojanskiPuz() :Polja() {
		tip = TROJANSKIPUZ;
	}
	int vratiKolicinu() { return 0; }
};

class Trava :
	public Polja
{
public:
	Trava() :Polja() {
		tip = TRAVA;
	}
	int vratiKolicinu() { return 0; }
};