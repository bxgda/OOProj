#include "Racunar.h"

Racunar::Racunar(string mmac)
{
	mac = mmac;
	ispravan = 0;
	ram = nullptr;
	monitor = nullptr;
	tastatura = nullptr;
}

Racunar::~Racunar()
{
	nizKomponenti.clear();
}

void Racunar::dodajRam(Komponenta* rram)
{
	ram = rram;
	ispravan = jelIspravan();
}

void Racunar::dodajKomponentu(Komponenta* nesto)
{
	nizKomponenti.push_back(nesto);
	ispravan = jelIspravan();
}

void Racunar::dodajMonitor(Periferija* mmonitor)
{
	monitor = mmonitor;
	ispravan = jelIspravan();
}

void Racunar::dodajTastaturu(Periferija* ttastatura)
{
	tastatura = ttastatura;
	ispravan = jelIspravan();
}

bool Racunar::jelIspravan()
{
	bool proc = 0, hdd = 0;
	if (ram == nullptr)
		return false;
	else if (monitor == nullptr)
		return false;
	else if (tastatura == nullptr)
		return false;
	else
	{
		for (int i = 0; i < nizKomponenti.size(); i++)
		{
			if (nizKomponenti[i]->vratiTip() == PROCESOR)
			{
				proc = 1;
			}
			if (nizKomponenti[i]->vratiTip() == HDD)
			{
				hdd = 1;
			}

			if (hdd && proc) break;
		}
	}

	if (proc == 0 || hdd == 0)
		return false;


	return true;
}

void Racunar::ispisi()
{
	//ispravan = jelIspravan();
	cout << "Racunar: " << mac << endl;
	if (ispravan)
	{
		cout << "ispravan" << endl;
		ram->ispisi();
		for (int i = 0; i < nizKomponenti.size(); i++)
		{
			nizKomponenti[i]->ispisi();
		}
		monitor->ispisi();
		tastatura->ispisi();
		cout << endl << endl;
	}
	else
	{
		cout << "neispravan" << endl << endl << endl;
	}
}


