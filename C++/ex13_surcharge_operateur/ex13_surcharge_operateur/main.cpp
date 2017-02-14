#include "surcharge.h"


void main(){

	int tab[10] = {0,1,2,3,4,5,6,7,8,9};
	Polynome a  = Polynome(10,tab);

	int tab2[10] = {10,11,12,13,14,15,16,17,18,19};
	Polynome b  = Polynome(10,tab2);

	Polynome c = a + b;
	
	a.afficher();
	b.afficher();
	c.afficher();

	system("pause");
	system("cls");

}