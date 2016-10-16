#include <iostream>
#include <string>

#include "Maison.h"

using std::cout;
using std::endl;
using std::string;



Maison::Maison(){
	avecJardin_ = false;
	nombreMurMitoyen_ = 2;
}

Maison::Maison( int nombreMurMitoyen, bool avecJardin, int age, int nombrePiece ) : Batiment( age,nombrePiece ) {

	nombreMurMitoyen_ = nombreMurMitoyen;
	avecJardin_ = avecJardin;

}



void Maison::afficher(){
	
	string jardin;

	if (avecJardin_){

		jardin="avec";

	} else {

		jardin="sans";

	}

	Batiment::afficher();
	cout << " " << nombreMurMitoyen_ << " mur(s) mitoyen(s) " << jardin << " jardin" << endl;
}



int Maison::augmenterNombre(int nbr){
	return nombreMurMitoyen_ += nbr;
}



Maison::~Maison(){

	cout << "Destructeur de Maison" << endl;

}
