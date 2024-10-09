#include "Skijaliste.h"

Skijaliste::Skijaliste(std::string naziv, std::string lokacija)
	: naziv(naziv), lokacija(lokacija) {}

Skijaliste::~Skijaliste()
{
	for (int i = 0; i < liftovi.size(); i++) 
		delete liftovi[i];
	liftovi.clear();
}

void Skijaliste::dodajLift(Lift* lift)
{
	liftovi.push_back(lift);
}

void Skijaliste::ispisi(std::ostream& izlaz) const
{
	izlaz << "Liftovi u skijalistu: " << naziv << " na mestu: " << lokacija << std::endl << std::endl;
	for (int i = 0; i < liftovi.size(); i++) {
		liftovi[i]->ispisi(izlaz);
		izlaz << std::endl;
	}
	izlaz << "--------------------------------------------" << std::endl;
}