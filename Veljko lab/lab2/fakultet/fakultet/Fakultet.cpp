#include "Fakultet.h"
Fakultet* Fakultet::f = nullptr;

Fakultet::Fakultet()
{

}

Fakultet::~Fakultet()
{
	for (RacunarskaUcionica* r : ucionice)
	{
		delete r;
	}
	ucionice.clear();
}

Fakultet* Fakultet::vratiInstancu()
{
	if (f == nullptr)
		f = new Fakultet();
	return f;
}

void Fakultet::postaviNaziv(string nnaziv)
{
	naziv = nnaziv;
}

void Fakultet::dodajUcionicu(RacunarskaUcionica* r)
{
	ucionice.push_back(r);
}

void Fakultet::izvestajOBrojuRacunara()
{
	int br = 0;
	for (int i = 0; i < ucionice.size(); i++)
	{
		br += ucionice[i]->vratiBrojRacunara();

	}
	cout << "Broj racunara u svim ucionicama: " << br << endl << endl;
}

void Fakultet::izvestajNeosposobljenih()
{
	int br = 0;
	for (int i = 0; i < ucionice.size(); i++)
	{
		br += ucionice[i]->brojNeosposobljenih();
	}
	cout << "Broj neosposobljenih racunara u svim ucionicama: " << br << endl;
}

void Fakultet::ispisi()
{
	cout << "Naziv fakulteta: " << naziv << endl << endl << endl;
	for (int i = 0; i < ucionice.size(); i++)
	{
		ucionice[i]->ispisi();
		cout << endl;
	}
}


