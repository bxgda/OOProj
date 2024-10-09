#include "RacunarskaUcionica.h"


class Fakultet
{
private:
	string naziv;
	Fakultet();
	vector<RacunarskaUcionica*> ucionice;
public:
	~Fakultet();
	static Fakultet* f;
	static Fakultet* vratiInstancu();
	void postaviNaziv(string nnaziv);
	void dodajUcionicu(RacunarskaUcionica* r);
	void izvestajOBrojuRacunara();
	void izvestajNeosposobljenih();
	void ispisi();
};

