#include "Ssd.h"

Ssd::Ssd()
{
	tip = SSD;
}

Ssd::Ssd(float bc)
{
	brzinaCitanja = bc;
	tip = SSD;
}

void Ssd::ispisi()
{
	cout << "SSD " << brzinaCitanja << endl;
}
