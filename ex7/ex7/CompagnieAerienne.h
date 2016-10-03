// N° 41 inclusion au début de fichier
// N° 40 regroupement par niveau d'inclusion
#include <iostream>
#include <string>

#define max 10 //nombre maximal de compagnies

using namespace std ;

//classcompagnieaerienne{
// N° 2 recommandation
class compagnieAerienne{

// N° 43 public puis protected puis private

	// N°3 int i + N°11
	// 45 initialisation des variable a leur déclaration
	int i_; //code de la compagnie

	string n_ ; //nom de la compagnie

	string v_ ; //ville de la compagnie

public :

	// N° 5 initialiserCompagnieAerienne
	void initialisationcompagnieaerienne(int ii, string nn, string vv) ;

	void afficher() ;

	// N° 5 afficherNombreCompagnieAerienne
	// N° 15 implicite name
	void afficherNombre();

};
