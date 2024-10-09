#include "Prikljucak.h"

Prikljucak::Prikljucak(int id, int brojMesta)
	: id(id), postavljen(false), brojMesta(brojMesta) {}

Prikljucak::~Prikljucak()
{
	skijasi.clear();
}

void Prikljucak::ukloniSkijasa(int skiPas)
{
	for (int i = 0; i < skijasi.size(); i++) {
		if (skijasi[i]->vratiSkiPas() == skiPas) {
			// delete skijasi[i];
			skijasi.erase(skijasi.begin() + i);
			return;
		}
	}
}

bool Prikljucak::proveriSkijasa(int _skiPas)
{
	for (Skijas* s : skijasi) {
		if (s->vratiSkiPas() == _skiPas)
			return true;
	}
	return false;
}

std::vector<int> Prikljucak::vratiListuSkiPasa()
{
	std::vector<int> lista;
	for (Skijas* s : skijasi)
		lista.push_back(s->vratiSkiPas());

	return lista;
}
