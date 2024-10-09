#pragma once
#include "Lift.h"
#include <vector>
#include <string>
#include <iostream>

class Lift;

class Skijaliste
{
private:
    std::string naziv;
    std::string lokacija;
    std::vector<Lift*> liftovi;

public:
    Skijaliste(std::string naziv, std::string lokacija);
    ~Skijaliste();

    void dodajLift(Lift* lift);
    void ispisi(std::ostream& izlaz) const;

    std::string vratiNaziv() const { return naziv; }
};
