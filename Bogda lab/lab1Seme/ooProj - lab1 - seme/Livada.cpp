#include "Livada.h"

Livada::Livada()
{
	this->n = 0;
	mat = nullptr;
}

Livada::~Livada()
{
	if (mat != nullptr) {
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < n; j++)
				delete mat[i][j];
			delete[] mat[i];
		}
		delete[] mat;
	}
}

void Livada::zauzmiMemoriju(int n)
{
	// zauzimanje memorije za kvadratnu matricu pokazivaca velicine n
	this->n = n;
	mat = new Polja * *[this->n];
	for (int i = 0; i < this->n; i++) {
		mat[i] = new Polja * [this->n];
		for (int j = 0; j < this->n; j++)
			mat[i][j] = nullptr;
	}
}

void Livada::ucitajLivadu(const char* imeFajla)
{
	// ucitavanje iz fajla i pravljenje objekata
	std::ifstream ulaz(imeFajla);
	if (!ulaz.good())
		throw "problem pri otvaranju fajla za ucitavanje";
	else {
		int velicina;
		char c;
		ulaz >> velicina;
		zauzmiMemoriju(velicina);
		for (int i = 0; i < n; i++)
			for (int j = 0; j < n; j++) {
				ulaz >> c;
				if (c == 't' || c == 's' || c == 'j') {	
					TipPolja tip;
					switch (c) {
						case 't':
							tip = TRAVA;
							break;
						case 's':
							tip = SEME;
							break;
						case 'j':
							tip = JAJE;
							break;
					}
					mat[i][j] = FabrikaObjekata::napraviPolje(tip);
				}
				else
					throw "u pocetku igre mogu samo na poljima da budu trava, jaje ili seme";
			}
	}
}

void Livada::ispisiLivadu(int red, int kolona)
{
	// ispis matrice
	std::cout << "pozicija pokusaja: " << red << " " << kolona << std::endl << std::endl;

	for (int i = 0; i < n; i++) {
		for (int j = 0; j < n; j++)
			if (!mat[i][j]->vratiOtkriveno())
				std::cout << ".  ";
			else {
				mat[i][j]->ispisiTip();
				std::cout << " ";
			}
		std::cout << std::endl;
	}
	std::cout << std::endl; 
	ispisiSaSakrivenim();
}

void Livada::ispisiSaSakrivenim()
{
	std::cout << std::endl;
	for (int i = 0; i < n; i++) {
		for (int j = 0; j < n; j++) {
			mat[i][j]->ispisiTip();
			std::cout << " ";
		}
		std::cout << std::endl;
	}
}

int Livada::izbrojiRuze()
{
	int br = 0;
	for (int i = 0; i < n; i++)
		for (int j = 0; j < n; j++)
			if (mat[i][j]->vratiTip() == RUZA)
				br++;
	return br;
}

bool Livada::proveriKraj()
{
	for (int i = 0; i < n; i++)
		for (int j = 0; j < n; j++)
			if (mat[i][j]->vratiTip() == JAJE || mat[i][j]->vratiTip() == SEME)
				return false;
	return true;
}
