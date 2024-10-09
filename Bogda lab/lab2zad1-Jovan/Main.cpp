#include "Skijaliste.h"

int main() {

	Skijaliste* s1 = new Skijaliste("Ski1", "Stara Planina");

	Lift* lift1 = new Lift(s1, "Lift 1", 50, TipLifta::DVOSED);
	Lift* lift2 = new Lift(s1, "Lift 2", 75, TipLifta::CETVOROSED);
	Lift* lift3 = new Lift(s1, "Lift 3", 30, TipLifta::TANJIR);

	// Liftovi u prikljucak
	s1->dodajLift(lift1);
	s1->dodajLift(lift2);
	s1->dodajLift(lift3);

	Dvosed* p1 = new Dvosed(1, 250);
	Dvosed* p2 = new Dvosed(2, 300);
	Cetvorosed* p3 = new Cetvorosed(3);
	Cetvorosed* p4 = new Cetvorosed(4);
	Cetvorosed* p5 = new Cetvorosed(5);
	Tanjir* t1 = new Tanjir(6);
	Tanjir* t2 = new Tanjir(7);

	// Prikljucci u liftove
	lift1->dodaj(p1);
	lift1->dodaj(p2);
	lift2->dodaj(p3);
	lift2->dodaj(p4);
	lift2->dodaj(p5);
	lift3->dodaj(t1);
	lift3->dodaj(t2);

	Skijas* skijas1 = new Skijas(12345, "Jovan", "Bogdanovic", 2003, 73);
	Skijas* skijas2 = new Skijas(54321, "Aleksandar", "Gospavic", 2003, 65);
	Skijas* skijas3 = new Skijas(97942, "Veljko", "Najdanovic", 2004, 88);
	Skijas* skijas4 = new Skijas(13467, "Marijana", "Ristic", 2003, 62);
	Skijas* skijas5 = new Skijas(97834, "Vojin", "Jevtovic", 2003, 82);
	Skijas* skijas6 = new Skijas(46791, "Aleksa", "Bibanovic", 2003, 85);
	Skijas* skijas7 = new Skijas(64318, "Mladen", "Jevtovic", 1998, 80);
	Skijas* skijas8 = new Skijas(79798, "Lazar", "Djordjevic", 1976, 99);
	Skijas* skijas9 = new Skijas(11122, "Mirko", "Mirkovic", 1999, 100);
	Skijas* skijas10 = new Skijas(44455, "Mario", "Maric", 2006, 55);

	// Skijasi u prikljucke sa odgovarajucim id-jem
	lift1->dodajSkijasa(skijas1, 1);
	lift1->dodajSkijasa(skijas2, 1);
	lift1->dodajSkijasa(skijas3, 2);
	lift2->dodajSkijasa(skijas7, 3);
	lift2->dodajSkijasa(skijas4, 4);
	lift2->dodajSkijasa(skijas5, 4);
	lift2->dodajSkijasa(skijas6, 4);
	lift2->dodajSkijasa(skijas8, 5);
	lift3->dodajSkijasa(skijas9, 6);
	lift3->dodajSkijasa(skijas10, 7);

	lift1->dodajSkijasa(skijas1, 2);
	// Celokupan ispis
	s1->ispisi(std::cout);
		
	// Najveca nosivost u liftu 1
	std::cout << std::endl << "Prikljucak sa najvecom nosivoscu u liftu 1: " << std::endl;
	Prikljucak* maks1 = lift1->vratiNajveci();
	maks1->ispisi(std::cout);

	// Najveca nosivost u liftu 3
	std::cout << std::endl << "Prikljucak sa najvecom nosivoscu u liftu tanjira: " << std::endl;
	Prikljucak* maks2 = lift3->vratiNajveci();
	maks2->ispisi(std::cout);

	// Promena kapaciteta lifta 2
	std::cout << "\nPromena kapaciteta lifta 2: " << std::endl;

	try {
		lift2->smanjiKapacitet(22);
	}
	catch (std::exception& e) {
		std::cout << e.what() << std::endl;
	}

	lift2->ispisi(std::cout);

	// Izbaci prikljucak iz lifta
	std::cout << "Izbacivanje prikljucka 2 iz lifta 1: " << std::endl;
	lift1->izbaci(2);
	lift1->ispisi(std::cout);

	// Ispis u fajlove
	lift1->sacuvajStanje("lift1.txt");
	lift2->sacuvajStanje("lift2.txt");
	lift3->sacuvajStanje("litf3.txt");

	std::cout << "Lista skiPasa skijasa u prikljucku 4:\n";
	std::vector<int> lista1 = lift2->vratiListuSkiPasa(4);
	for (int i = 0; i < lista1.size(); i++)
		std::cout << lista1[i] << " ";

	std::cout << std::endl << std::endl;

	std::cout << "Lista skiPasa skijasa u prikljucku 7:\n";
	std::vector<int> lista2 = lift3->vratiListuSkiPasa(7);
	for (int i = 0; i < lista2.size(); i++)
		std::cout << lista2[i] << " ";

	std::cout << std::endl << std::endl << "KRAJ!" << std::endl;


	// Brisanje svega
	delete s1;
	delete p1;
	delete p2;
	delete p3;
	delete p4;
	delete p5;
	delete t1;
	delete t2;
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