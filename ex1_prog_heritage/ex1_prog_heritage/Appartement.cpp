#pragma once
#include <iostream>

#include "Appartement.h"

using std::cout;
using std::endl;


Appartement::Appartement(){
	nombreEtage_ = 5;
	superficie_ = 200;
}

Appartement::Appartement(int nombreEtage, int superficie, int age, int nombrePiece) : Batiment (age, nombrePiece){

	nombreEtage_ = nombreEtage;
	superficie_ = superficie;

}



void Appartement::afficher(){
	Batiment::afficher();
	cout << nombreEtage_ << " etage(s)" << superficie_ << " de superficie "<< endl;
}



int Appartement::augmenterNombre(int nbr){
	return nombreEtage_ += nbr;
}



Appartement::~Appartement(){

	cout << " Destructeur de Appartement " << endl;

}
