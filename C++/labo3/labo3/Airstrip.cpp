#include <iostream>

#include "Airstrip.h"

using std::cout;
using std::endl;

int Airstrip::stripCreated = 0;

Airstrip::Airstrip( int length, int composition, int nummer ){

	length_ = length;
	composition_ = composition;
	nummer_ = nummer;
	Airstrip::stripCreated++;
}



bool Airstrip::compareLength(Airstrip & a){

	if ( this->length_ == a.length_ ){
		
		cout << "Length of the 2 Airstrip are equal" << endl;
		return true;

	} else {
	
		cout << "Length of the 2 Airstrip are not equal" << endl;
		return false;

	}

}

bool Airstrip::compareComposition(Airstrip & a){

	if ( this->composition_ == a.composition_ ){

		cout << "Composition of the 2 Airstrip are equal" << endl;
		return true;

	} else {

		cout << "Composition of the 2 Airstrip are not equal" << endl;
		return false;

	}

}



bool Airstrip::compareNummer(Airstrip & a){

	if ( this->nummer_ == a.nummer_ ){

		cout << "Nummer of the 2 Airstrip are equal" << endl;
		return true;

	} else {

		cout << "Nummer of the 2 Airstrip are not equal" << endl;
		return false;

	}

}



void Airstrip::displayInformation(){

	cout << "Length : " << length_ << endl;
	cout << "Composition : " << composition_ << endl;
	cout << "Nummer : " << nummer_ << endl;

}



Airstrip::~Airstrip(){
}
