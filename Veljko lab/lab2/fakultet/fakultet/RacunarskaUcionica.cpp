#include "RacunarskaUcionica.h"

RacunarskaUcionica::RacunarskaUcionica(int ooznaka)
{
	oznaka = ooznaka;
	brojRacunara = 0;

	svic = new Svic();
}

RacunarskaUcionica::~RacunarskaUcionica()
{
	for (Racunar* r : racunari)
	{
		delete r;
	}
	racunari.clear();
	delete svic;
}

void RacunarskaUcionica::dodajRacunar(Racunar* r)
{
	racunari.push_back(r);
	svic->postaviPort(r->vratiMac());
	brojRacunara++;
}

void RacunarskaUcionica::ispisiTablu(Racunar* r)
{
	tabla->prikazi(r);
}

void RacunarskaUcionica::dodajTablu()
{
	tabla = new PametnaTabla();
}

void RacunarskaUcionica::obrisiTablu()
{
	if (tabla)
		delete tabla;
}



int RacunarskaUcionica::brojNeosposobljenih()
{
	int rez = 0;
	for (int i = 0; i < racunari.size(); i++)
	{
		if (!racunari[i]->jelIspravan())
			rez++;
	}
	return rez;
}
void RacunarskaUcionica::ispisi()
{
	cout << "Oznaka ucionice: " << oznaka << endl
		<< "Broj racunara u ucionici: " << brojRacunara << endl
		<< "Broj neosposobljenih racunara u ucionici: " << brojNeosposobljenih() << endl << endl;
	for (int i = 0; i < racunari.size(); i++)
	{
		racunari[i]->ispisi();
	}
	cout << "------------------------------------------------------------------" << endl;
}




