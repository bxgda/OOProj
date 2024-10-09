#include "Lift.h"

bool Lift::proveriSkijasa(int skiPas)
{
	// Proveravamo da l je skijas vec u liftu
	for (int i = 0; i < nizPrikljucaka.size(); i++) 
		if (nizPrikljucaka[i]->proveriSkijasa(skiPas))
			return true;
	return false;
}

Lift::Lift(Skijaliste* skijaliste, std::string naziv, int kapacitet, TipLifta tip)
{
	this->skijaliste = skijaliste;
	this->naziv = naziv;
	this->kapacitet = kapacitet;
	this->tip = tip;
}

Lift::~Lift()
{
	// Ne brisu se i sami prikljucci zob veze agregacije izmedju lifta i prikljucka
	nizPrikljucaka.clear();
}

void Lift::dodaj(Prikljucak* p)
{
	// Jedan lift ima samo jedan tip prikljucka pa dodajemo koje gde treba
	if (tip == TipLifta::DVOSED && p->vratiBrojMesta() != 2) {
		std::cout << "Ne moze taj prikljucak u lift sa dvosedima!" << std::endl;
		return;
	}
	else if (tip == TipLifta::CETVOROSED && p->vratiBrojMesta() != 4) {
		std::cout << "Ne moze taj prikljucak u lift cetvoroseda!" << std::endl;
		return;
	}
	else if (tip == TipLifta::TANJIR && p->vratiBrojMesta() != 1) {
		std::cout << "Ne moze taj prikljucak u lift sa tanjirima" << std::endl;
	}

	// Proveravamo da l je prikljucak mozda postavljen i da l ima mesta
	if (nizPrikljucaka.size() < kapacitet && !p->vratiPostavljen()) {
		nizPrikljucaka.push_back(p);
		p->postavi();
	}
	else
		std::cout << "Prikljucak: " << p->vratiId() << " ne moze u lift jer nema mesta u liftu: " << naziv << std::endl;
}

bool Lift::izbaci(int id)
{
	// Nadjemo bas taj prikljucak i postavimo njegovu vrednost postavljen na false i uklonimo iz vektora
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
	//// Za cetvorosede je najveci onaj sa izmerenom vrednoscu
	//if (tip == TipLifta::CETVOROSED) {
	//	Cetvorosed* max = (Cetvorosed*)nizPrikljucaka[0];
	//	for (int i = 1; i < nizPrikljucaka.size(); i++)
	//		if (((Cetvorosed*)nizPrikljucaka[i])->izmeri() > max->izmeri())
	//			max = (Cetvorosed*)nizPrikljucaka[i];
	//	return max;
	//}
	//// Za dvosede je najveci sa najvecom unapred masom
	//else {
	//	Dvosed* max = (Dvosed*)nizPrikljucaka[0];
	//	for (int i = 1; i < nizPrikljucaka.size(); i++)
	//		if (((Dvosed*)nizPrikljucaka[i])->vratiMaxMasu() > max->vratiMaxMasu())
	//			max = (Dvosed*)nizPrikljucaka[i];
	//	return max;
	//}

	int maxInd = 0;
	for (int i = 1; i < nizPrikljucaka.size(); i++)
		if (nizPrikljucaka[i]->vratiMasu() > nizPrikljucaka[maxInd]->vratiMasu())
			maxInd = i;
	return nizPrikljucaka[maxInd];
}

void Lift::smanjiKapacitet(int zaKoliko)
{
	// Ne moze da se smanji kapacitet manje od 0 i ne moze da se smanji da bude manje od trenutnog broja prikljucka
	if (kapacitet - zaKoliko < 0 || kapacitet - zaKoliko < nizPrikljucaka.size())
		throw std::exception("Ne moze toliko da se smanji kapacitet!");
	kapacitet -= zaKoliko;
}

void Lift::povecajKapacitet(int zaKoliko)
{
	// Ovde moze za koliko god
	kapacitet += zaKoliko;
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
	for (int i = 0; i < nizPrikljucaka.size(); i++) 
		if (nizPrikljucaka[i]->vratiId() == id)
			return nizPrikljucaka[i];
	return nullptr;
}

bool Lift::dodajSkijasa(Skijas* s, int id)
{
	// Ako nadje id onda dodaje skijasa i ako skijas nije vec u liftu
	if (!proveriSkijasa(s->vratiSkiPas())) {
		if (vratiPrikljucak(id)) {
			vratiPrikljucak(id)->dodajSkijasa(s);
			return true;
		}
	}
	else
		std::cout << "Skijas je vec u liftu!" << std::endl << std::endl;
	return false;
}

std::vector<int> Lift::vratiListuSkiPasa(int id)
{
	if (vratiPrikljucak(id))
		return vratiPrikljucak(id)->vratiListuSkiPasa();
	return std::vector<int>();
}

void Lift::ispisi(std::ostream& izlaz)
{
	izlaz << std::left << std::setw(12) << "Skijaliste: " << skijaliste->vratiNaziv() << std::endl
		<< std::left << std::setw(12) << "Naziv: " << naziv << std::endl
		<< std::left << std::setw(12) << "Kapacitet: " << kapacitet << std::endl
		<< std::left << std::setw(12) << "Prikljucci: " << std::endl << std::endl;

	// Prednosti vector klase
	for (Prikljucak* p : nizPrikljucaka)
		p->ispisi(izlaz);

	izlaz << std::endl;
}