
#include "Komponenta.h"

class Procesor : public Komponenta
{
	float takt;
public:
	Procesor();
	Procesor(float ttakt);
	void ispisi();
};

