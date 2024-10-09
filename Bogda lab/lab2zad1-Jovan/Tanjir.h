#pragma once
#include "Prikljucak.h"
class Tanjir :
    public Prikljucak
{
public:
    Tanjir(int id);

    float izmeri() const;
    virtual void dodajSkijasa(Skijas* s) override;
    virtual void ispisi(std::ostream& izlaz) const override;

    virtual bool jeTezi(Prikljucak* p);
    virtual float vratiMasu();
};

