#pragma once
#include "Fakultet.h"

void main()
{
	Fakultet* fakultet = Fakultet::vratiInstancu();
	fakultet->postaviNaziv("Elektronski");

	// komponente
	Komponenta* r1 = new Ram(3200, 8, TipMemorije::DDR3);
	Komponenta* r2 = new Ram(4800, 12, TipMemorije::DDR5);
	Komponenta* p1 = new Procesor(4.4);
	Komponenta* p2 = new Procesor(3.6);
	Komponenta* h1 = new Hdd(5400);
	Komponenta* h2 = new Hdd(7200);
	Komponenta* s1 = new Ssd(500);

	// periferije
	Periferija* m1 = new Monitor(34, "1920 x 1080", "Acer");
	Periferija* m2 = new Monitor(31, "3840 x 2160", "Asus");
	Periferija* t1 = new Tastatura(Tip::CIRILICNA);
	Periferija* t2 = new Tastatura(Tip::LATINICNA);

	// racunari

	Racunar* rac1 = new Racunar("AC:4B:C8:2F:9E:7D");
	Racunar* rac2 = new Racunar("52:54:00:AB:CD:EF");
	Racunar* rac3 = new Racunar("00:E0:4C:2F:8B:A1");
	Racunar* rac4 = new Racunar("A4:5E:60:9D:F2:3C");

	rac1->dodajKomponentu(p1);
	rac1->dodajKomponentu(h1);
	rac1->dodajRam(r1);
	rac1->dodajMonitor(m1);
	rac1->dodajTastaturu(t1);
	//rac1->ispisi();

	rac2->dodajKomponentu(p2);
	//rac2->dodajKomponentu(h2);
	rac2->dodajRam(r2);
	rac2->dodajMonitor(m2);
	rac2->dodajTastaturu(t2);
	//rac2->ispisi();

	rac3->dodajKomponentu(p1);
	rac3->dodajKomponentu(h2);
	rac3->dodajRam(r1);
	rac3->dodajMonitor(m2);
	rac3->dodajTastaturu(t1);
	rac3->dodajKomponentu(s1);

	rac4->dodajKomponentu(p2);
	rac4->dodajKomponentu(h1);
	rac4->dodajRam(r2);
	rac4->dodajMonitor(m1);
	rac4->dodajTastaturu(t2);


	// racunarske ucionice
	RacunarskaUcionica* rUcionica1 = new RacunarskaUcionica(1);
	RacunarskaUcionica* rUcionica2 = new RacunarskaUcionica(2);
	rUcionica1->dodajRacunar(rac1);
	rUcionica1->dodajRacunar(rac2);
	rUcionica2->dodajRacunar(rac3);
	rUcionica2->dodajRacunar(rac4);

	

	//cout << rUcionica1->brojNeosposobljenih();

	// fakultet
	fakultet->dodajUcionicu(rUcionica1);
	fakultet->dodajUcionicu(rUcionica2);
	fakultet->izvestajNeosposobljenih();
	fakultet->izvestajOBrojuRacunara();
	fakultet->ispisi();


	// pametne table
	

	rUcionica1->dodajTablu();
	rUcionica1->ispisiTablu(rac1);
	//rUcionica1->ispisiTablu();
}