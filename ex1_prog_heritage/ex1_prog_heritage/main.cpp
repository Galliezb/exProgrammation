#include <stdlib.h>
#include <iostream>

#include "Batiment.h"
#include "Maison.h"
#include "Appartement.h"

using std::cout;
using std::endl;

void main(){

	// ******************************** EXERCIE  1 *******************************
	/*
	Maison test(5,true,5,10);

	test.afficher();
	system("pause");
	system("cls");

	cout << " plus de piece " << test.augmenterNombre(3) << endl;
	system("pause");
	system("cls");

	Appartement apart(5,100,25,15);
	apart.afficher();
	cout << "Nouveau nombre etage : " << apart.augmenterNombre(5) << endl;
	system("pause");
	system("cls");
	*/
	// ******************************** EXERCICE 2 puis 3 *********************************
	Batiment * tabBatiment[3];

	Maison m(4,true,50,10);
	tabBatiment[0] = &m;
	Appartement a(10,250,60,12);
	tabBatiment[1] = &a;
	Batiment *B1;
	B1=new Appartement(60,50,60,54);

	tabBatiment[2] = B1;

	for ( unsigned short int i = 0; i < 3; i++ ){
	
		tabBatiment[i]->afficher();
		tabBatiment[i]->augmenterNombre(5);
		//*tabBatiment[i]->afficher();	
		system("pause");
		system("cls");
	}


}