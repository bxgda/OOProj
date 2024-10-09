#pragma once
#include <vector>
#include "Ram.h"
#include "Procesor.h"
#include "Hdd.h"
#include "Ssd.h"
#include "Monitor.h"
#include "Tastatura.h"

class Periferija;
class Komponenta;

class Racunar
{
private:
	string mac;
	bool ispravan;
	Komponenta* ram;
	vector<Komponenta*> nizKomponenti;
	Periferija* monitor;
	Periferija* tastatura;
public:
	Racunar(string mmac);
	~Racunar();
	void dodajRam(Komponenta* rram);
	void dodajKomponentu(Komponenta* nesto); // to je za procesor ili hdd ili ssd
	void dodajMonitor(Periferija* mmonitor);
	void dodajTastaturu(Periferija* ttastatura);
	bool jelIspravan();
	string vratiMac() { return mac; }
	void ispisi();
};

