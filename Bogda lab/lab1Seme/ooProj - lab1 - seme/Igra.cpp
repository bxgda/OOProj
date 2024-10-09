#include "Igra.h"

Igra* Igra::igra = nullptr;

Igra::Igra()
{
	mlaz = nullptr;
	livada = FabrikaObjekata::napraviLivadu();
}

void Igra::igraj()
{
	bool gadjaoOtkriveno = false;

	// glavna petlja igre
	while (!krajIgre()) {

		gadjaoOtkriveno = false;
		// proveravamo da li je neko seme ili jaje otkriveno da bi ga polili
		for (int i = 0; i < livada->vratiN() && !gadjaoOtkriveno; i++) {
			for (int j = 0; j < livada->vratiN() && !gadjaoOtkriveno; j++) {

				if ((*livada)[i][j]->vratiOtkriveno() && ((*livada)[i][j]->vratiTip() == SEME)) {
					mlaz = FabrikaObjekata::napraviMlaz(i, j, livada);
					mlaz->polijPolje();
					gadjaoOtkriveno = true;
				}
			}
		}
		if (!gadjaoOtkriveno) {
			mlaz = FabrikaObjekata::napraviMlaz(std::rand() % livada->vratiN(), std::rand() % livada->vratiN(), livada);
			mlaz->polijPolje();
		}

		//potez po potez manuelno sa unosom koordinata
		/*int r, k;
		std::cin >> r >> k;
		mlaz = FabrikaObjekata::napraviMlaz(r, k, livada);
		mlaz->polijPolje();*/


		livada->ispisiLivadu(mlaz->vratiRed(), mlaz->vratiKolonu());
		delete mlaz;


		//potez po potez manuelno
		/*int x;
		std::cin >> x;*/

		Sleep(250);
		system("cls");
	}


	int osvojeniPoeni = poeni();
	std::cout << "Kraj igre!" << std::endl << "osvojeni poeni: " << osvojeniPoeni << std::endl;
	livada->ispisiSaSakrivenim();
}

bool Igra::krajIgre()
{
	// proveravamo da li su otkrivena sva polja jajeta ili semena
	return livada->proveriKraj();
}

int Igra::poeni()
{
	return livada->izbrojiRuze();
}

Igra::~Igra()
{
	delete livada;
}

void Igra::napraviIgru()
{
	if (igra == nullptr)
		igra = new Igra();
}

void Igra::pokreniIgru()
{
	ucitaj();
	igraj();
}

void Igra::ucitaj()
{
	livada->ucitajLivadu("LivadaUnos.txt");
}

Igra* Igra::vratiIgru()
{
	return igra;
}