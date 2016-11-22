#include "surcharge.h"

Polynome::Polynome(int degre = 0,int tabInt[] = NULL){
	degre_= degre;
	ptrInt_ = tabInt;
}

void Polynome::afficher(){
	cout << "Affichage du polynome ( degre = " << degre_ <<" ) : " << endl;
	for ( int i = 0; i < degre_; i++ ) {
		// + si pas 0
		if ( i  != 0 ){ cout << " + "; }; 
		// aff
		cout << ptrInt_[i] << "x^" << i;
		//cout << *(ptrInt_+i) << endl;

	}
	cout << endl;
}

Polynome::~Polynome(){
	cout << "Deconstructeur de Polynome" << endl;
}

Polynome operator+(Polynome & a, Polynome & b){

	int degre = a.degre_;
	int tab[10] = {0};

	for ( int i = 0; i < degre; i++){
		cout << "a : " << a.ptrInt_[i] << "/t/t b : " << b.ptrInt_[i] << endl;
		tab[i] = a.ptrInt_[i] + b.ptrInt_[i];
	}

	return Polynome(degre,tab);
}
