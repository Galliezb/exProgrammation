#include <iostream>

#include "Batiment.h"
#include "Appartement.h"
#include "Batiment.h"

using std::cout;
using std::endl;



Batiment::Batiment(){
	age_=10;
	nombrePiece_=5;
}



Batiment::Batiment(int age, int nombrePiece){
	age_ = age;
	nombrePiece_=nombrePiece;
}



void Batiment::afficher(){
	cout << " age : " << age_ << " nombre de piece" << nombrePiece_ << endl;
}



int Batiment::augmenterNombre(int nbr){
	return nombrePiece_ += nbr;
}



Batiment::~Batiment(){
	cout << " Destructeur de Batiment " << endl;
}
