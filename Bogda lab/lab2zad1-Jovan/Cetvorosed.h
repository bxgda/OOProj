#pragma once
#include "Prikljucak.h"

class Cetvorosed :
    public Prikljucak
{
public:
    Cetvorosed(int id);

    float izmeri() const;
    virtual void dodajSkijasa(Skijas* s) override;
    virtual void ispisi(std::ostream& izlaz) const override;
    virtual float vratiMasu() override;
    virtual bool jeTezi(Prikljucak* p);
};

