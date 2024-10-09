#include "Skijaliste.h"

Skijaliste::Skijaliste(std::string naziv, std::string lokacija)
	: naziv(naziv), lokacija(lokacija) {}

Skijaliste::~Skijaliste()
{
	for (Lift* l : liftovi)
		delete l;

	liftovi.clear();
}

void Skijaliste::dodajLift(Lift* lift)
{
	liftovi.push_back(lift);
}

void Skijaliste::ispisi(std::ostream& izlaz) const
{
	izlaz << "LIFTOVI U SKIJALISTU: " << naziv << " (" << lokacija << ")\n";
	izlaz << "####################################################\n\n";
	for (Lift* l : liftovi) {
		l->ispisi(izlaz);
		izlaz << "\n";
	}
	izlaz << "####################################################\n\n";
}