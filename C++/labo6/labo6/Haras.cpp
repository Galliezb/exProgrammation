#include "Haras.h"

int Haras::objectCreated_ = 0;

//Haras::Haras(string name, string telefoon, string website, int number, string street, string postalCode, string town){
//
//	name_ = name;
//	telefoon_ = telefoon;
//	website_ = website;
//	address_ = Address(number,street,postalCode,town);
//
//}



Haras::Haras(string name, string telefoon, string website, Address a){

	name_ = name;
	telefoon_ = telefoon;
	website_ = website;
	address_ = a;

}



Haras::~Haras(){

	cout << "Destruction object Haras" << endl;

}



/********************* CLASS ADDRESS *********************/
Address::Address(int number, string street, string postalCode, string town){

	number_ = number;
	street_ = street;
	postalCode_ = postalCode;
	town_ = town;

}

Address::~Address(){

	cout << "Destruction of object Address" << endl;

}
