#include "Svic.h"

Svic::Svic()
{
	i = 0;
}

void Svic::postaviPort(string mac)
{
	portovi[i++] = mac;
}
