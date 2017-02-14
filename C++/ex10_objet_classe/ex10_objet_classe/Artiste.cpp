#include "Artiste.h"

Artiste::Artiste() : nom_("Dupond"), prenom_("Julien"), age_(8){
	cout << "Destructeur de Artiste" << endl;
}

Artiste::Artiste(const Artiste &){
}

void Artiste::afficherInfos(){
	cout << "Nom : " << nom_ << endl;
	cout << "prenom : " << prenom_ << endl;
	cout << " age : " << age_ << endl;
}

int Artiste::ajouterAge(int nbr=1){
	age_+=nbr;
	return age_;
}

bool Artiste::comparer(const Artiste & a, const Artiste & b){
	if ( a.age_ == b.age_ && a.prenom_ == b.prenom_ && a.nom_ == b.prenom_){
		
		return true;

	} else {
		return false;
	}
}

Artiste::~Artiste(){
	cout << "Destructeur de Artiste" << endl;
}
