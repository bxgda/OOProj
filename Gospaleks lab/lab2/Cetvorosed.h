#pragma once
#include "Prikljucak.h"

class Cetvorosed :
    public Prikljucak
{
public:
    Cetvorosed(int id);

    float izmeri() const;

    // Implementacija virtuelne metode
    virtual float opterecenje();
    virtual bool dodajSkijasa(Skijas* s) override;
    virtual void ispisi(std::ostream& izlaz) const override;
};

