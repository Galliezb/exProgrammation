#include <iostream>

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
	cout << "Age : " << age_ << " possedant : " << nombrePiece_ << " piece(s)";
}



void Batiment::augmenterNombrePiece(int nbr){
	nombrePiece_ += nbr;
}



Batiment::~Batiment(){
	cout << " Destructeur de Batiment " << endl;
}
