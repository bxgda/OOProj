#pragma once
#include "Prikljucak.h"
class Dvosed :
    public Prikljucak
{
private:
    float maxMasa;

public:
    Dvosed(int id, float maxMasa);

    virtual void dodajSkijasa(Skijas* s) override;
    virtual void ispisi(std::ostream& izlaz) const override;

    virtual bool jeTezi(Prikljucak* p) override;
    virtual float vratiMasu() override;
    float vratiTrenutnuMasu() const;
};

