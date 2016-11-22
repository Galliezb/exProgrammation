#include "amitie.h"

void main(){
	system("cls");

	// Creation objet
	Vetement &a = Vetement(59,"bleu","Jean's");
	Vetement &b = Vetement(46,"violet","T_shirt");
	Vetement &c = Vetement(59,"bleu","Jean's");

	a.afficher();
	system("pause");
	system("cls");

	b.afficher();
	system("pause");
	system("cls");

	c.afficher();
	system("pause");
	system("cls");

	// la référence évite la copie de l'objet dans comparer
	// elle évite donc d'appeler 2 fois le déconstructeur
	comparer(a,b);
	comparer(b,c);
	comparer(a,c);

	system("pause");
	system("cls");
}