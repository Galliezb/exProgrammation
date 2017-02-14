#include <iostream>
#include <stdlib.h>

#include "Adresse.h"
#include "Aeroport.h"
#include "Airstrip.h"

using std::endl;
using std::cout;

void main(){

	// creation de l'adresse et de l'objet Aeroport
	cout << " Creation de l'addresse..." << endl;
	system("pause");
	Adresse a(59,95000,"rue quelque part","Paris");
	cout << " Creation de l'aeroport et affectation de l'addresse..." << endl;
	system("pause");
	Aeroport aeroport(18,"Charles de Gaule", a);

	// Ajout des piste  atterissage
	cout << " Ajout de piste d'atterissage sur l'objet aeropot..." << endl;
	system("pause");
	system("cls");
	aeroport.addAirstrip(950,5,1);
	aeroport.addAirstrip(120,6,1);
	aeroport.addAirstrip(0,0,0);
	aeroport.addAirstrip(0,0,0);

	cout << "***** Debut comparaison ****" << endl;
	cout << "***** Comparaison piste 0 et 1 ****" << endl;
	aeroport.comparAirstrip(0,1);

	system("pause");
	system("cls");
	cout << "***** Comparaison piste 2 et 3 ****" << endl;
	aeroport.comparAirstrip(2,3);


	system("pause");
	system("cls");
	cout << "Total airstrip created : " << Airstrip::stripCreated << endl;
	

	system("pause");
	system("cls");
}