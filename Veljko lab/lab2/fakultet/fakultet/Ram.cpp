#include "Ram.h"

Ram::Ram()
{
	tip = RAM;
}

Ram::Ram(float ttakt, float km, TipMemorije ttip)
{
	takt = ttakt;
	kolicinaMemorije = km;
	tip1 = ttip;
}

void Ram::ispisi()
{
	cout << "RAM ";
	vratiTippp();
	cout << " " << kolicinaMemorije << endl;
}
