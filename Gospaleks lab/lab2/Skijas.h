#pragma once
#include <string>
#include <vector>

class Skijas
{
private:
	int skiPas;
	std::string ime;
	std::string prezime;
	int godinaRodjenja;
	float masa;

public:
	Skijas(int skiPas, std::string ime, std::string prezime, int godinaRodjenja, float masa)
		: skiPas(skiPas), ime(ime), prezime(prezime), godinaRodjenja(godinaRodjenja), masa(masa) {}

	float vratiMasu() const { return masa; }
	int vratiSkiPas() const { return skiPas; }
	std::string vratiIme() const { return ime; }
};

