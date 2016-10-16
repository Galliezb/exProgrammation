#include "Clavier.h"


void main(){

	Clavier clavier("logitech",102,59.95);
	clavier.afficherTouches();
	cout << " prix avec TVA " << clavier.afficherPrixAvecTva() << endl;
	cout << "Prix diminue, nouveau prix : " << clavier.diminuerPrix() << endl;
	cout << "Prix augmnete, nouveau prix : " << clavier.augmenterPrix() << endl;
	cout << "Nombre d'objet : " << Clavier::getNombreStatic() << endl;
	system("pause");

}