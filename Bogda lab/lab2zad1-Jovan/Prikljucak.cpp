#include "Prikljucak.h"

bool Prikljucak::proveriSkijasa(int skiPas)
{
	for (int i = 0; i < skijasi.size(); i++)
		if (skijasi[i]->vratiSkiPas() == skiPas)
			return true;
	return false;
}

Prikljucak::Prikljucak(int id, int brojMesta)
	: id(id), postavljen(false), brojMesta(brojMesta) {}

Prikljucak::~Prikljucak()
{
	// Ako se unisti priljucak logicno da ce i skijasi da "sidju"
	skijasi.clear();
}

void Prikljucak::ukloniSkijasa(int skiPas)
{
	for (int i = 0; i < skijasi.size(); i++)
		if (skijasi[i]->vratiSkiPas() == skiPas) {
			skijasi.erase(skijasi.begin() + i);
			return;
		}
}

std::vector<int> Prikljucak::vratiListuSkiPasa()
{
	std::vector<int> lista;
	for (int i = 0; i < skijasi.size(); i++) 
		lista.push_back(skijasi[i]->vratiSkiPas());
	return lista;
}
