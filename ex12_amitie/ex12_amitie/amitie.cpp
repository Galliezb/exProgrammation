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
	if (   a.taille_ == b.taille_ 
		&& a.couleur_ == b.couleur_
		&& a.type_ == b.type_ ) {
		cout << "Identique";
	} else {
		cout << "Non identique";
	}
	cout << endl;
}

Styliste::Styliste(string nom, int annee_experience){
	nom_ = nom;
	annee_experience_ = annee_experience;
}

void Styliste::afficher(){
	cout << "nom : " << nom_ << endl;
	cout << "Experience : " << annee_experience_ << "an(s)" << endl;
}

void Styliste::modifierTaille(Vetement & v, int taille){
	v.taille_ = taille;
}

void Styliste::modifierCouleur(Vetement & v, string couleur){
	v.couleur_ = couleur;
}

void Styliste::modifierType(Vetement & v, string type){
	v.type_ = type;
}


Styliste::~Styliste(){
	cout << "Deconstructeur de Styliste" << endl;
}
