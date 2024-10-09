#include "Dvosed.h"

Dvosed::Dvosed(int id, float maxMasa)
    : Prikljucak(id, 2), maxMasa(maxMasa) {}

float Dvosed::vratiTrenutnuMasu() const
{
    // Ovo nam treba da ne bi prikljucak "preopterecen"
    float masa = 0;
    for (int i = 0; i < skijasi.size(); i++) 
        masa += skijasi[i]->vratiMasu();
    return masa;
}

void Dvosed::dodajSkijasa(Skijas* s)
{   
    // Dodajemo ako nije "preopterecen" i ako ima mesta naravno
    if (skijasi.size() < brojMesta && s->vratiMasu() + vratiTrenutnuMasu() < maxMasa)
        skijasi.push_back(s);
    else
        std::cout << "Nema mesta ili je skijas: " << s->vratiIme() << " pretezak za dvosed: " << id << std::endl;
}

void Dvosed::ispisi(std::ostream& izlaz) const
{
    izlaz << "Dvosed " << id << " (" << skijasi.size() << "/" << 2 << ")" << std::endl
        << "\tMasa: " << vratiTrenutnuMasu() << "/" << maxMasa << " kg" << std::endl
        << "\tSkijasi: ";

    for (int i = 0; i < skijasi.size(); i++) {
        izlaz << skijasi[i]->vratiIme() << " ";
    }
    izlaz << std::endl << std::endl;
}

bool Dvosed::jeTezi(Prikljucak* p)
{
    return (this->vratiMasu() > p->vratiMasu());
}

float Dvosed::vratiMasu() 
{
    return maxMasa;
}
