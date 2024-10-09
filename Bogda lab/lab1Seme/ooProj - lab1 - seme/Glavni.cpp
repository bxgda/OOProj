#include "Igra.h"

int main() {
	
	srand(time(NULL));

	Igra* igra;
	Igra::napraviIgru();
	igra = Igra::vratiIgru();

	try {
		igra->pokreniIgru();
	}
	catch (const char* poruka) {
		std::cout << poruka << std::endl;
	}
	
	delete igra;
}