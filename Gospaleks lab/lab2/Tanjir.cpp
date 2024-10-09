#include "Tanjir.h"

Tanjir::Tanjir(int id, float _maksMasa)
	: Prikljucak(id, 1), maksMasa(_maksMasa) {
}

float Tanjir::vratiTrenutnuMasu() const
{
    if (skijasi.empty())
        return 0.0f;

    return skijasi[0]->vratiMasu();
}


float Tanjir::opterecenje()
{
    return vratiTrenutnuMasu();
}

bool Tanjir::dodajSkijasa(Skijas* s)
{
    if (skijasi.size() < brojMesta && s->vratiMasu() + vratiTrenutnuMasu() < maksMasa)
    {
        skijasi.push_back(s);
        return true;
    }
    else
    {
        std::cout << "Nema mesta za skijasa " << s->vratiIme() << " na tanjiru " << id << std::endl;
        return false;
    }
}

void Tanjir::ispisi(std::ostream& izlaz) const
{
    izlaz << "Tanjir " << id << " (" << skijasi.size() << "/" << 1 << ")  |  ";
    izlaz << "Masa: " << vratiTrenutnuMasu() << "/" << maksMasa << " kg  |  ";
    izlaz << "Skijasi: ";
    if (!skijasi.empty())
        izlaz << skijasi[0]->vratiIme();
    izlaz << std::endl;
}
