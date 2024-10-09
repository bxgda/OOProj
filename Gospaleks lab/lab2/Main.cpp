#include "Skijaliste.h"

int main() {

	Skijaliste* staraPlanina = new Skijaliste("Ski1", "Stara Planina");

	Lift* lift1 = new Lift(staraPlanina, "Lift 1", 50, TipLifta::DVOSED);
	Lift* lift2 = new Lift(staraPlanina, "Lift 2", 75, TipLifta::CETVOROSED);
	Lift* lift3 = new Lift(staraPlanina, "Lift 3", 25, TipLifta::TANJIR);

	// Dodaj liftove u skijaliste
	staraPlanina->dodajLift(lift1);
	staraPlanina->dodajLift(lift2);
	staraPlanina->dodajLift(lift3);

	Dvosed* p1 = new Dvosed(1, 250);
	Dvosed* p2 = new Dvosed(2, 300);
	Cetvorosed* p3 = new Cetvorosed(3);
	Cetvorosed* p4 = new Cetvorosed(4);
	Cetvorosed* p5 = new Cetvorosed(5);
	Tanjir* p6 = new Tanjir(6, 120);
	Tanjir* p7 = new Tanjir(7, 150);
	Tanjir* p8 = new Tanjir(8, 90);

	// Dodaj prikljucke u liftove
	lift1->dodaj(p1);
	lift1->dodaj(p2);
	lift2->dodaj(p3);
	lift2->dodaj(p4);
	lift2->dodaj(p5);
	lift3->dodaj(p6);
	lift3->dodaj(p7);
	lift3->dodaj(p8);

	Skijas* skijas1 = new Skijas(12345, "Pera", "Peric", 1995, 75);
	Skijas* skijas2 = new Skijas(54321, "Mika", "Mikic", 1990, 101);
	Skijas* skijas3 = new Skijas(97942, "Zika", "Zikic", 2001, 64);
	Skijas* skijas4 = new Skijas(13467, "Laza", "Lazic", 1985, 95);
	Skijas* skijas5 = new Skijas(97834, "Jova", "Jovic", 1971, 105);
	Skijas* skijas6 = new Skijas(46791, "Mladen", "Lazarevic", 2007, 57);
	Skijas* skijas7 = new Skijas(64318, "Bogdan", "Bogdanovic", 1991, 89);
	Skijas* skijas8 = new Skijas(79798, "Stevan", "Stevanovic", 1976, 99);
	Skijas* skijas9 = new Skijas(97849, "Aleksandar", "Gospavic", 2003, 67);
	Skijas* skijas10 = new Skijas(73184, "Radivoje", "Gospavic", 1970, 105);

	// Dodaj skijase u lift
	lift1->dodajSkijasa(skijas1, 1);
	lift1->dodajSkijasa(skijas2, 1);
	lift1->dodajSkijasa(skijas3, 2);
	//lift1->dodajSkijasa(skijas1, 2);
	lift2->dodajSkijasa(skijas7, 3);
	lift2->dodajSkijasa(skijas4, 4);
	lift2->dodajSkijasa(skijas5, 4);
	lift2->dodajSkijasa(skijas6, 4);
	lift2->dodajSkijasa(skijas8, 5);
	lift3->dodajSkijasa(skijas9, 6);
	lift3->dodajSkijasa(skijas10, 7);

	// Ispis svih liftova na skijalistu
	staraPlanina->ispisi(std::cout);
		
	std::cout << "\nNajveci prikljucak u liftu 2: " << std::endl;
	Prikljucak* maks2 = lift2->vratiNajveci();
	maks2->ispisi(std::cout);

	std::cout << "\nNajveci prikljucak u liftu 3: " << std::endl;
	Prikljucak* maks3 = lift3->vratiNajveci();
	maks3->ispisi(std::cout);

	// Promena kapaciteta lifta
	std::cout << "\nPromena kapaciteta lifta 1: " << std::endl;

	try {
		lift1->smanjiKapacitet(20);
	}
	catch (std::exception& e) {
		std::cout << e.what() << std::endl;
	}

	lift1->ispisi(std::cout);

	// Izbaci prikljucak iz lifta
	std::cout << "\nIzbacivanje prikljucka 2 iz lifta 1: " << std::endl;
	lift1->izbaci(2);
	lift1->ispisi(std::cout);

	// Sacuvaj stanje liftova
	lift1->sacuvajStanje("lift1.txt");
	lift2->sacuvajStanje("lift2.txt");

	// Lista ski pasa u prikljucku 1
	std::cout << "Lista skiPasa skijasa u prikljucku 1:\n";
	std::vector<int> lista = lift1->vratiListuSkiPasa(1);
	std::cout << "[";
	for (int i = 0; i < lista.size(); ++i) {
		if (i == lista.size() - 1)
			std::cout << lista[i];
		else
			std::cout << lista[i] << ", ";
	}
	std::cout << "]\n";


	// Skijaliste brise i liftove
	delete staraPlanina;

	// Obrisi prikljucke
	delete p1;
	delete p2;
	delete p3;
	delete p4;
	delete p5;
	delete p6;
	delete p7;
	delete p8;

	// Obrisi skijase
	delete skijas1;
	delete skijas2;
	delete skijas3;
	delete skijas4;
	delete skijas5;
	delete skijas6;
	delete skijas7;
	delete skijas8;
	delete skijas9;
	delete skijas10;

	return 0;
}