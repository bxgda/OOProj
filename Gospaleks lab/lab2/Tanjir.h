#pragma once
#include "Prikljucak.h"
class Tanjir :
	public Prikljucak
{
private:
	float maksMasa;
	
public:
	Tanjir(int id, float _maksMasa);

	float vratiTrenutnuMasu() const;

	// Implementacija virtuelne metode
	virtual float opterecenje() override;
	virtual bool dodajSkijasa(Skijas* s) override;
	virtual void ispisi(std::ostream& izlaz) const override;
};

