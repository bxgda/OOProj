#pragma once
#include "Livada.h"
#include "Mlaz.h"

class Livada;
class Mlaz;
class Polja;

class FabrikaObjekata
{
public:
	static Polja* napraviPolje(TipPolja t);
	static Polja* napraviSemeSaKolicinom(int kolicina);
	static Mlaz* napraviMlaz(int red, int kolona, Livada* livada);
	static Livada* napraviLivadu();
};

