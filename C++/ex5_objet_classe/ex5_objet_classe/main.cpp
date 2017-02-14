#include "Clavier.h"


void main(){

	Clavier clavier("logitech",102,59.95);
	clavier.afficherTouches();
	cout << " prix avec TVA " << clavier.afficherPrixAvecTva() << endl;
	system("pause");
}