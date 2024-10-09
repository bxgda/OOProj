#include "Hdd.h"

Hdd::Hdd(float bro)
{
	brojObrtaja = bro;
	tip = HDD;
}

void Hdd::ispisi()
{
	cout << "HDD " << brojObrtaja << endl;
}
