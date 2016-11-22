#include "amitie.h"

void main(){
	system("cls");

	// Creation objet
	Vetement &a = Vetement(59,"bleu","Jean's");
	Vetement &b = Vetement(46,"Violet","T_shirt");
	Vetement &c = Vetement(59,"bleu","Jean's");

	Styliste &s = Styliste("Jean",15);

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
	cout << "a & b avant modification : " << endl;
	comparer(a,b);
	s.afficher();
	s.modifierTaille(a,46);
	s.modifierCouleur(a,"Violet");
	s.modifierType(a,"T_shirt");
	cout << "*****************" << endl;
	a.afficher();
	b.afficher();
	cout << "*****************" << endl;
	cout << "a & b après modification : " << endl;
	comparer(a,b);

	system("pause");
	system("cls");
}