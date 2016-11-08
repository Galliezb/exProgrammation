#include "Humain.h"

void main(){

	Humanoide *h1;
	h1 = new Humanoide(190,"chair","asiatique",90,"Pierre",'M',50);

	h1->afficher();

	delete h1;

	system("Pause");
}