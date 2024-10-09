#include "Tanjir.h"

Tanjir::Tanjir(int id)
	: Prikljucak(id, 1) {}

float Tanjir::izmeri() const
{
	// "Senzor"
	float suma = 0;
	for (Skijas* s : skijasi)
		suma += s->vratiMasu();
	return suma;
}

void Tanjir::dodajSkijasa(Skijas* s)
{
	if (skijasi.size() < brojMesta)
		skijasi.push_back(s);
	else
		std::cout << "Nema vise mesta za skijasa " << s->vratiIme() << "na tanjiru" << std::endl;
}

void Tanjir::ispisi(std::ostream& izlaz) const
{
	izlaz << "Tanjir " << id << " (" << skijasi.size() << "/" << 1 << ")" << std::endl
		<< "\tIzmerena masa: " << izmeri() << " kg" << std::endl
		<< "\tSkijasi: ";

	for (int i = 0; i < skijasi.size(); i++) {
		izlaz << skijasi[i]->vratiIme() << " ";
	}
	izlaz << std::endl << std::endl;
	izlaz << std::endl << std::endl;
}

bool Tanjir::jeTezi(Prikljucak* p)
{
	return (this->vratiMasu() > p->vratiMasu());
}

float Tanjir::vratiMasu()
{
	return izmeri();
}
