#include "Cetvorosed.h"

Cetvorosed::Cetvorosed(int id)
    : Prikljucak(id, 4) {}

float Cetvorosed::izmeri() const
{
    // "Senzor"
    float suma = 0;
    for (int i = 0; i < skijasi.size(); i++)
        suma += skijasi[i]->vratiMasu();
    return suma;
}

void Cetvorosed::dodajSkijasa(Skijas* s)
{
    if (skijasi.size() < brojMesta)
        skijasi.push_back(s);
    else
        std::cout << "Nema mesta za skijasa " << s->vratiIme() << " na cetvorosedu " << id << std::endl;
}

void Cetvorosed::ispisi(std::ostream& izlaz) const
{
    izlaz << "Cetvorosed " << id << " (" << skijasi.size() << "/" << 4 << ")" << std::endl
        << "\tIzmerena masa: " << izmeri() << " kg" << std::endl
        << "\tSkijasi: ";

    for (int i = 0; i < skijasi.size(); i++) {
        izlaz << skijasi[i]->vratiIme() << " ";
    }
    izlaz << std::endl << std::endl;
    izlaz << std::endl << std::endl;
}

float Cetvorosed::vratiMasu()
{
    return izmeri();
}

bool Cetvorosed::jeTezi(Prikljucak* p)
{
    return (this->vratiMasu() > p->vratiMasu());
}
