#include <iostream>
#include <math.h>

#include "main.h"

using namespace std;


// a)
int saisirParametres ()
{

	int rayon;

	cout << "Veuillez introduire un float comme rayon :"<< endl;
	cin >> rayon;

	return rayon;

}



// b)
void saisirParametres ( int *largeur, int *longueur )
{
	int la,lo;
	cout << "Veuillez introduire la largeur ( int )" << endl;
	cin >> la;
	cout << "veuillez introduire la longueur ( int ) " << endl;
	cin >> lo;

	*largeur = la;
	*longueur = lo;
}



// c)
void saisirParametres ( int *longueurUne, int *longueurDeux, float *angle )
{
	int la,lo;
	float an;
	cout << "Veuillez introduire la premiere longueur ( int )" << endl;
	cin >> la;
	cout << "veuillez introduire la deuxieme longueur ( int ) " << endl;
	cin >> lo;
	cout << "veuillez introduire la valeur de l'angle ( int ) " << endl;
	cin >> an;

	*longueurUne = la;
	*longueurDeux = lo;
	*angle = an;
}



// d)
void afficherSurface ( float rayon )
{
	cout << " Surface cercle : " << (3.14 * rayon * rayon ) << endl;
}



// e)
void afficherSurface ( float largeur, float longueur )
{
	cout << " Surface rectangle : " << ( largeur * longueur ) << endl;
}



// f)
void afficherSurface ( float coteUn, float coteDeux, float angle )
{
	cout << " Surface rectangle : " << ( (coteUn * coteDeux)/2 * sin(angle) ) << endl;
}



// g)
void main (int argc, char *argv[])
{
	cout << "Parametres : " << endl;
	for (short int i = 0; i<argc; i++){
		cout << "Param " << i << " = " << argv[i] << endl;
	}

	if ( argc < 2 ){
		cout << "ERROR : 2 params minimum requis";
	} else if ( argc > 2 && argc <=5 ){
			
	} else {
	
	}
	system("pause");
}