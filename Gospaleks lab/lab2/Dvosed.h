#pragma once
#include "Prikljucak.h"
class Dvosed :
    public Prikljucak
{
private:
    float maxMasa;

public:
    Dvosed(int id, float maxMasa);

    float vratiMaxMasu() const { return maxMasa; }
    float vratiTrenutnuMasu() const;

    // Implementacija virtuelne metode
    virtual float opterecenje();
    virtual bool dodajSkijasa(Skijas* s) override;
    virtual void ispisi(std::ostream& izlaz) const override;
};

