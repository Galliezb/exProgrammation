#include <stdlib.h>
#include <iostream>

#include "Batiment.h"
#include "Maison.h"
#include "Appartement.h"

using std::cout;
using std::endl;

void main(){

	//Batiment *test1[10];
	//	Batiment *ptrTab[10] = Ba;

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


}