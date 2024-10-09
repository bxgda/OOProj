
#include "Komponenta.h"

enum TipMemorije
{
	DDR3,
	DDR4,
	DDR5
};
class Ram : public Komponenta
{
	float takt;
private:
	float kolicinaMemorije;
	TipMemorije tip1;

public:
	Ram();
	Ram(float ttakt, float km, TipMemorije ttip);
	void vratiTippp()
	{
		if (tip1 == DDR3)
			cout << "DDR3";
		else if (tip1 == DDR4)
			cout << "DDR4";
		else
			cout << "DDR5";
	}
	void ispisi();
};

