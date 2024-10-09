#include "Monitor.h"

Monitor::Monitor()
{
}

Monitor::Monitor(float de, string rez, string mmarka)
{
	dijagonalaEkrana = de;
	rezolucija = rez;
	marka = mmarka;
}

void Monitor::ispisi()
{
	cout << "Monitor " << marka << " " << dijagonalaEkrana << " " << rezolucija << endl;
}
