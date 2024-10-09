#include "FabrikaObjekata.h"

Polja* FabrikaObjekata::napraviPolje(TipPolja t)
{
	// na osnovu tipa polja, vrati odgovarajuci objekat
	switch (t)
	{
	case JAJE:
		return new Jaje();
	case SEME:
		return new Seme();
	case RUZA:
		return new Ruza();
	case PUZ:
		return new Puz();
	case TROJANSKARUZA:
		return new TrojanskaRuza();
	case TROJANSKIPUZ:
		return new TrojanskiPuz();
	default:
		return new Trava();
	}
}

Polja* FabrikaObjekata::napraviSemeSaKolicinom(int kolicina)
{
	return new Seme(kolicina);
}

Mlaz* FabrikaObjekata::napraviMlaz(int red, int kolona, Livada * livada)
{
	return new Mlaz(red, kolona, livada);
}

Livada* FabrikaObjekata::napraviLivadu()
{
	return new Livada();
}
