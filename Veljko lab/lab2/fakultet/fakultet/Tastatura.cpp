#include "Tastatura.h"

Tastatura::Tastatura()
{
}

Tastatura::Tastatura(Tip ttip)
{
	tipTastature = ttip;
}

void Tastatura::ispisi()
{
	cout << "Tastatura ";
	if (tipTastature == LATINICNA)
		cout << "latinicna" << endl;
	else if (tipTastature == CIRILICNA)
		cout << "cirilicna" << endl;
	else
		cout << "engleska" << endl;
}
