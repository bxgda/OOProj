#include "Dvosed.h"

Dvosed::Dvosed(int id, float maxMasa)
    : Prikljucak(id, 2), maxMasa(maxMasa) {}

float Dvosed::vratiTrenutnuMasu() const
{
    // trenutna masa prikljucka
    float masa = 0;
    for (Skijas* s : skijasi)
        masa += s->vratiMasu();

    return masa;
}

float Dvosed::opterecenje()
{
    return vratiTrenutnuMasu();
}

bool Dvosed::dodajSkijasa(Skijas* s)
{   
    // ako ima mesta i ako je masa sa novim skijasem manja od max mase
    if (skijasi.size() < brojMesta && s->vratiMasu() + vratiTrenutnuMasu() < maxMasa)
    {
        skijasi.push_back(s);
        return true;
    }
    else
    {
        std::cout << "Nema mesta za skijasa " << s->vratiIme() << " na dvosedu " << id << std::endl;
        return false;
    }
}

void Dvosed::ispisi(std::ostream& izlaz) const
{
    izlaz << "Dvosed " << id << " (" << skijasi.size() << "/" << 2 << ")  |  ";
    izlaz << "Masa: " << vratiTrenutnuMasu() << "/" << maxMasa << " kg  |  ";
    izlaz << "Skijasi: ";
    for (auto s : skijasi) {
        if (s == skijasi.back())
            izlaz << s->vratiIme();
		else
			izlaz << s->vratiIme() << ", ";
    }
    izlaz << std::endl;
}
