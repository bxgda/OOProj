#include "Cetvorosed.h"

Cetvorosed::Cetvorosed(int id)
    : Prikljucak(id, 4) {}

float Cetvorosed::izmeri() const
{
    float suma = 0;
    for (Skijas* s : skijasi)
        suma += s->vratiMasu();
    return suma;
}

float Cetvorosed::opterecenje()
{
    return izmeri(); // to je onaj senzor
}

bool Cetvorosed::dodajSkijasa(Skijas* s)
{
    if (skijasi.size() < brojMesta)
    {
        skijasi.push_back(s);
        return true;
    }
    else
    {
        std::cout << "Nema mesta za skijasa " << s->vratiIme() << " na cetvorosedu " << id << std::endl;
        return false;
    }
}

void Cetvorosed::ispisi(std::ostream& izlaz) const
{
    izlaz << "Cetvorosed " << id << " (" << skijasi.size() << "/" << 4 << "):" << "  |  ";
    izlaz << "Izmerena masa: " << izmeri() << " kg  |  ";
    izlaz << "Skijasi: ";
    for (auto s : skijasi) {
        if (s == skijasi.back())
            izlaz << s->vratiIme();
        else
            izlaz << s->vratiIme() << ", ";
    }
    izlaz << std::endl;
}
