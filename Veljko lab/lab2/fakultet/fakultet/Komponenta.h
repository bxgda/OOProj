#pragma once
#include<iostream>
using namespace std;
enum TipKomponente
{
	RAM,
	PROCESOR,
	HDD,
	SSD,
};
class Komponenta
{
protected:

	TipKomponente tip;
public:
	virtual void ispisi() = 0;
	Komponenta();
	Komponenta(float ttakt);
	TipKomponente vratiTip() { return tip; }

};

