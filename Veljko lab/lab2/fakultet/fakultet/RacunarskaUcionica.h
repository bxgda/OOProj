#pragma once
#include "Svic.h"
#include "Racunar.h"
#include "PametnaTabla.h"
class RacunarskaUcionica
{
private:
	int oznaka;
	int brojRacunara;
	Svic* svic;
	vector <Racunar*> racunari;
	PametnaTabla* tabla;
public:
	RacunarskaUcionica(int ooznaka);
	~RacunarskaUcionica();
	void dodajRacunar(Racunar* r);
	void ispisiTablu(Racunar* r);
	void dodajTablu();
	void obrisiTablu();

	int vratiBrojRacunara() { return brojRacunara; }
	int vratiOznaku() { return oznaka; }
	int brojNeosposobljenih();

	void ispisi();
};

