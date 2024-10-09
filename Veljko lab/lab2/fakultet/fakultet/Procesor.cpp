#include "Procesor.h"

Procesor::Procesor()
{
	tip = PROCESOR;
}

Procesor::Procesor(float ttakt)
{
	takt = ttakt;
	tip = PROCESOR;
}

void Procesor::ispisi()
{
	cout << "Procesor " << takt << endl;
}
