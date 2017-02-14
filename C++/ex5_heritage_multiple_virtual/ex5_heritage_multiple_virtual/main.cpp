#include "Humain.h"

void main(){

	Humanoide *h1;
	h1 = new Humanoide(190,"chair","asiatique",90,"Pierre",'M',50,666);

	h1->afficher();
	//h1->Element::afficher();

	delete h1;

	system("Pause");
}