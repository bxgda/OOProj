#include "Mlaz.h"
#include <cstdlib>
#include <iomanip>


Mlaz::Mlaz(int red, int kolona, Livada* livada)
{
	this->red = red;
	this->kolona = kolona;
	this->livada = livada;
	this->jacina = std::rand() % 2 + 1;
}

void Mlaz::polijPolje()
{
	poruka(1);
	
	if (!(*livada)[red][kolona]->vratiOtkriveno())
		(*livada)[red][kolona]->postaviOtkriveno();
	
	TipPolja tip = (*livada)[red][kolona]->vratiTip();

	int zbir = (*livada)[red][kolona]->vratiKolicinu() + jacina;

	if (tip == SEME) {
		switch (zbir) {
			case 2:
				ruzaSlucaj2();
				break;
			case 3:
				ruzaSlucaj3();
				break;
			case 4:
				ruzaSlucaj4();
				break;
		}
	}
	else if (tip == JAJE) {
		switch (zbir) {
			case 2:
				jajeSlucaj2();
				break;
			case 3:
				jajeSlucaj3();
				break;
		}
	} 
	else
		poruka(7);
}

void Mlaz::ruzaSlucaj2()
{
	// ako je zbir 2, seme postaje ruza
	poruka(2);
	delete (*livada)[red][kolona];
	(*livada)[red][kolona] = FabrikaObjekata::napraviPolje(RUZA);
	(*livada)[red][kolona]->postaviOtkriveno();
}

void Mlaz::ruzaSlucaj3()
{
	// ako je zbir 3 na susedna polja se rasejava seme iste kolicine ako je polje trava
	poruka(3);
	int kolicina = (*livada)[red][kolona]->vratiKolicinu();
	delete (*livada)[red][kolona];
	(*livada)[red][kolona] = FabrikaObjekata::napraviPolje(TRAVA);
	(*livada)[red][kolona]->postaviOtkriveno();

	int poRedovima[] = { -1, -1, -1, 0, 0, 1, 1, 1 };
	int poKolonama[] = { -1, 0, 1, -1, 1, -1, 0, 1 };

	for (int i = 0; i < 8; i++) {
		int noviRed = red + poRedovima[i];
		int novaKolona = kolona + poKolonama[i];


		if (noviRed >= 0 && noviRed < livada->vratiN() && novaKolona >= 0 && novaKolona < livada->vratiN()) {

			// p je pogodjeno polje i koristimo ga da kod bude pregledniji
			Polja* p = (*livada)[noviRed][novaKolona];

			// ako je prazno polje (trava)
			if (p->vratiTip() == TRAVA) {
				if (!p->vratiOtkriveno()) {
					delete p;
					(*livada)[noviRed][novaKolona] = FabrikaObjekata::napraviSemeSaKolicinom(kolicina);
				}
				else {
					delete p;
					(*livada)[noviRed][novaKolona] = FabrikaObjekata::napraviSemeSaKolicinom(kolicina);
					(*livada)[noviRed][novaKolona]->postaviOtkriveno();
				}
			}
		}
	}
}

void Mlaz::ruzaSlucaj4()
{
	poruka(4);
	Pozicija* poz = ruza4jaje3(RUZA);
	delete[] poz;
}

void Mlaz::jajeSlucaj2()
{
	poruka(5);
	
	delete (*livada)[red][kolona];
	(*livada)[red][kolona] = FabrikaObjekata::napraviPolje(PUZ);
	(*livada)[red][kolona]->postaviOtkriveno();

	int poRedovima[] = { -1, -1, -1, 0, 0, 1, 1, 1 };
	int poKolonama[] = { -1, 0, 1, -1, 1, -1, 0, 1 };

	for (int i = 0; i < 8; i++) {

		int noviRed = red + poRedovima[i];
		int novaKolona = kolona + poKolonama[i];


		if (noviRed >= 0 && noviRed < livada->vratiN() && novaKolona >= 0 && novaKolona < livada->vratiN()) {

			// p je pogodjeno polje i koristimo ga da kod bude pregledniji
			Polja* p = (*livada)[noviRed][novaKolona];

			// ako je prazno polje (trava)
			if (p->vratiTip() == RUZA) {
				if (!p->vratiOtkriveno()) {
					delete p;
					(*livada)[noviRed][novaKolona] = FabrikaObjekata::napraviPolje(TRAVA);
				}
				else {
					delete p;
					(*livada)[noviRed][novaKolona] = FabrikaObjekata::napraviPolje(TRAVA);
					(*livada)[noviRed][novaKolona]->postaviOtkriveno();
				}
			}
		}
	}
}

void Mlaz::jajeSlucaj3()
{
	poruka(6);
	
	Pozicija* poz = ruza4jaje3(PUZ);


	for (int j = 0; j < 3; j++) {
		
		int poRedovima[] = { -1, -1, -1, 0, 0, 1, 1, 1 };
		int poKolonama[] = { -1, 0, 1, -1, 1, -1, 0, 1 };

		for (int i = 0; i < 8; i++) {
			int noviRed = poz[j].pozRed + poRedovima[i];
			int novaKolona = poz[j].pozKolona + poKolonama[i];

			if (noviRed >= 0 && noviRed < livada->vratiN() && novaKolona >= 0 && novaKolona < livada->vratiN()) {

				// p je pogodjeno polje i koristimo ga da kod bude pregledniji
				Polja* p = (*livada)[noviRed][novaKolona];

				// ako je ruza
				if (p->vratiTip() == RUZA) {
					if (!p->vratiOtkriveno()) {
						delete p;
						(*livada)[noviRed][novaKolona] = FabrikaObjekata::napraviPolje(TRAVA);
					}
					else {
						delete p;
						(*livada)[noviRed][novaKolona] = FabrikaObjekata::napraviPolje(TRAVA);
						(*livada)[noviRed][novaKolona]->postaviOtkriveno();
					}
				}
			}
		}
	}
	delete[] poz;
}

Pozicija* Mlaz::ruza4jaje3(TipPolja tip)
{
	delete (*livada)[red][kolona];
	if (tip == PUZ)
		(*livada)[red][kolona] = FabrikaObjekata::napraviPolje(TROJANSKIPUZ);
	else if (tip == RUZA)
		(*livada)[red][kolona] = FabrikaObjekata::napraviPolje(TROJANSKARUZA);
	else
		throw "los tip";

	(*livada)[red][kolona]->postaviOtkriveno();

	int n = livada->vratiN();

	Pozicija* pozicije = new Pozicija[3];

	for (int i = 0; i < 3; i++) {
		do {
			pozicije[i].pozRed = std::rand() % n;
			pozicije[i].pozKolona = std::rand() % n;
		} while (pozicije[i] == Pozicija(red, kolona));

		// ako generise slucajno iste pozicije onda smanjimo i da bi napravili jos jednu poziciju
		for (int j = 0; j < i; j++) {
			if (pozicije[i] == pozicije[j]) {
				i--;
				break;
			}
		}
	}

	int r, k;
	for (int i = 0; i < 3; i++) {
		// r i k cisto zbog lepseg koda 
		r = pozicije[i].pozRed;
		k = pozicije[i].pozKolona;
		if (!(*livada)[r][k]->vratiOtkriveno()) {
			delete (*livada)[r][k];
			(*livada)[r][k] = FabrikaObjekata::napraviPolje(tip);
		}
		else {
			delete (*livada)[r][k];
			(*livada)[r][k] = FabrikaObjekata::napraviPolje(tip);
			(*livada)[r][k]->postaviOtkriveno();
		}
	}
	return pozicije;
}

void Mlaz::poruka(int slucaj)
{
	// sve poruke koje treba da se ispisu
	switch (slucaj) {
		case 1:
			std::cout << std::left << std::setw(20) << "JACINA MLAZA: " << jacina << std::endl << std::endl;
			break;
		case 2:
			std::cout << std::left << std::setw(20) << "KOLICINA SEMENA: " << (*livada)[red][kolona]->vratiKolicinu() << std::endl << std::endl;
			std::cout << "ruza slucaj 2 - Seme je postalo ruza" << std::endl << std::endl;
			break;
		case 3:
			std::cout << std::left << std::setw(20) << "KOLICINA SEMENA: " << (*livada)[red][kolona]->vratiKolicinu() << std::endl << std::endl;
			std::cout << "ruza slucaj 3 - Seme se rasejava" << std::endl << std::endl;
			break;
		case 4:
			std::cout << std::left << std::setw(20) << "KOLICINA SEMENA: " << (*livada)[red][kolona]->vratiKolicinu() << std::endl << std::endl;
			std::cout << "ruza slucaj 4 - Seme je postalo trojanska ruza i na tri random mesta se postavi ruza" << std::endl << std::endl;
			break;
		case 5:
			std::cout << std::endl << std::endl << "jaje slucaj 2 - jaje je postalo puz a puz je pojeo ruze oko sebe" << std::endl << std::endl;
			break;
			break;
		case 6 :
			std::cout << std::endl << std::endl << "jaje slucaj 3 - jaje je postalo trojanski puz koji je generisao puzeve na 3 random pozicije" << std::endl << std::endl;
			break;
		default :
			std::cout << std::endl << std::endl << "pogodjeno je polje koje nista ne radi" << std::endl << std::endl;
			break;
	}
}

