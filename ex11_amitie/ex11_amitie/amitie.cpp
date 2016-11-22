#include "amitie.h"

Vetement::Vetement(int taille, string couleur, string type){
	taille_=taille;
	couleur_=couleur;
	type_=type;
}

void Vetement::afficher(){
	cout << "taille : " << taille_ << endl;
	cout << "couleur : " << couleur_ << endl;
	cout << "type : " << type_ << endl;

}

Vetement::~Vetement(){
	cout << "Deconstructeur de Vetement" << endl;
}

void comparer(Vetement &a, Vetement &b){
	cout << "Comparaison : ";
	if (   a.taille_ == b.taille_ 
		&& a.couleur_ == b.couleur_
		&& a.type_ == b.type_ ) {
		cout << "Identique";
	} else {
		cout << "Non identique";
	}
	cout << endl;
}
