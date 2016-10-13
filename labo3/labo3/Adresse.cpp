#include <iostream>

#include "Adresse.h"

using std::cout;
using std::endl;



Adresse::Adresse(int number, int postalCode, string street, string town){

	number_ = number;
	postalCode_ = postalCode;
	street_ = street;
	town_ = town;

}



void Adresse::display(){

	cout << "Address : " << endl;
	cout << "N° " << number_ << street_ << endl;
	cout << postalCode_ << town_ << endl;

}



Adresse::~Adresse(){
}
