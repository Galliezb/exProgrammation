#include "Clavier.h"

Clavier::Clavier(){
	marque_ = "";
	nombreTouche_ = 0;
	prix_ = 0;
}

Clavier::Clavier(string marque, short int nombreTouches, float prix){
	marque_ = marque;
	nombreTouche_ = nombreTouches;
	prix_ = prix;
}



void Clavier::afficherTouches(){
	cout << " Le clavier possede " << nombreTouche_ << "touches pour un prix de " << prix_ << endl;
}



double Clavier::afficherPrixAvecTva(){
	return ( prix_ * 0.21 + prix_ );
}

double Clavier::augmenterPrix(){
	prix_++;
	return prix_;
}

double Clavier::diminuerPrix(){
	prix_--;
	return prix_;
}


Clavier::~Clavier(){
}
