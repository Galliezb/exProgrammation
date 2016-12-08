#include "surcharge.h"

Polynome::Polynome(){
	// default constructer
	cout << "Construcrteur pas défaut" << endl;
	degre_ = 10;
	for ( int i = 0; i < degre_; i++){
		cout << "i : " << i << "\t\t valeur : " << ptrTabInt_[i] << endl;
	}
}

Polynome::Polynome(int degre,int tabInt[]){
	degre_= degre;
	ptrTabInt_ = tabInt;
	cout << "Construcrteur par copie" << endl;
}

void Polynome::afficher(){
	cout << "Affichage du polynome ( degre = " << degre_ <<" ) : " << endl;
	for ( int i = 0; i < degre_; i++ ) {
		// + si pas 0
		if ( i  != 0 ){ cout << " + "; }; 
		// aff
		cout << ptrTabInt_[i] << "x^" << i;

	}
	cout << endl;
}

Polynome operator+( const Polynome &a, const Polynome &b){

	// new int retourne un pointeur sur le tableau d'int
	int* ptrTab =  new int[10];
	for (int i = 0; i<a.degre_; i++){
		ptrTab[i] = 0;
	}
	Polynome tmp(a.degre_ , ptrTab);

	tmp.degre_ = a.degre_;

	for ( int i = 0; i < tmp.degre_; i++){
		//cout << "total : " << a.ptrTabInt_[i] + b.ptrTabInt_[i] << "\t\ta : " << a.ptrTabInt_[i] << "\t\t b : " << b.ptrTabInt_[i] << " i=>" << i << endl;
		tmp.ptrTabInt_[i] = a.ptrTabInt_[i] + b.ptrTabInt_[i];
	}


	system("pause");


	return tmp;
}


Polynome::~Polynome(){
	cout << "Deconstructeur de Polynome" << endl;
	delete ptrTabInt_;
}
