#include "Lift.h"

Lift::Lift(Skijaliste* skijaliste, std::string naziv, int kapacitet, TipLifta tip)
{
	this->skijaliste = skijaliste;
	this->naziv = naziv;
	this->kapacitet = kapacitet;
	this->tip = tip;
}

Lift::~Lift()
{
	nizPrikljucaka.clear();
}

void Lift::dodaj(Prikljucak* p)
{
	// Provera da li se dodaje odgovarajuci tip prikljucka
	if (tip == TipLifta::DVOSED && p->vratiBrojMesta() != 2) {
		std::cout << "Ovaj lift prima samo dvosede." << std::endl;
		return;
	}
	else if (tip == TipLifta::CETVOROSED && p->vratiBrojMesta() != 4) {
		std::cout << "Ovaj lift prima samo cetvorosede." << std::endl;
		return;
	}

	// Dodaje novi prikljucak ako ima mesta i ako nije vec postavljen u nekom drugom liftu
	if (nizPrikljucaka.size() < kapacitet && !p->vratiPostavljen()) {
		nizPrikljucaka.push_back(p);
		p->postavi();
	}
	else
		std::cout << "Nema mesta za prikljucak " << p->vratiId() << " na liftu " << naziv << std::endl;
}

bool Lift::izbaci(int id)
{
	for (int i = 0; i < nizPrikljucaka.size(); i++) {
		if (nizPrikljucaka[i]->vratiId() == id) {
			nizPrikljucaka[i]->skloni();
			nizPrikljucaka.erase(nizPrikljucaka.begin() + i);
			return true;
		}
	}
	return false;
}

Prikljucak* Lift::vratiNajveci()
{
	Prikljucak* max = nizPrikljucaka[0];
	for (int i = 1; i < nizPrikljucaka.size(); i++)
		if (nizPrikljucaka[i]->opterecenje() > max->opterecenje())
			max = nizPrikljucaka[i];
	return max;
}

void Lift::smanjiKapacitet(int za)
{
	if (kapacitet - za < 0 || kapacitet - za < nizPrikljucaka.size())
		throw std::exception("IZUZETAK::Nije moguce toliko smanjiti kapacitet lifta.\n");

	kapacitet -= za;
}

void Lift::povecajKapacitet(int za)
{
	kapacitet += za;
}

void Lift::sacuvajStanje(std::string imeFajla)
{
	std::ofstream izlaz(imeFajla);
	if (izlaz.good())
		ispisi(izlaz);

	izlaz.close();
}

Prikljucak* Lift::vratiPrikljucak(int id)
{
	for (Prikljucak* p : nizPrikljucaka)
		if (p->vratiId() == id)
			return p;
	return nullptr;
}

bool Lift::proveriSkijasa(int skiPas)
{
	for (Prikljucak* p : nizPrikljucaka) {
		if (p->proveriSkijasa(skiPas))
			return true;
	}

	return false;
}

bool Lift::dodajSkijasa(Skijas* s, int id)
{
	if (!proveriSkijasa(s->vratiSkiPas())) {

		Prikljucak* p = vratiPrikljucak(id);
		if (p != nullptr) {
			if (p->dodajSkijasa(s))
				return true;
			else
				return false;
		}

	}
	else {
		std::cout << "Skijas sa skiPas-om " << s->vratiSkiPas() << " je vec u nekom prikljucku.\n";
	}

	return false;
}

std::vector<int> Lift::vratiListuSkiPasa(int id)
{
	Prikljucak* p = vratiPrikljucak(id);
	if (p != nullptr)
		return p->vratiListuSkiPasa();

	return std::vector<int>();
}

void Lift::ispisi(std::ostream& izlaz)
{
	izlaz << std::left << std::setw(15) << "Naziv: " << naziv << std::endl;
	izlaz << std::left << std::setw(15) << "Kapacitet: " << kapacitet << std::endl;
	izlaz << std::left << std::setw(15) << "Skijaliste: " << skijaliste->vratiNaziv() << std::endl;
	izlaz << std::left << std::setw(15) << "Prikljucci: " << std::endl;

	for (Prikljucak* p : nizPrikljucaka)
		p->ispisi(izlaz);

	izlaz << std::endl;
}