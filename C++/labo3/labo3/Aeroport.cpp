#include <iostream>

#include "Aeroport.h"
#include "Airstrip.h"
#include "Adresse.h"

using std::cout;
using std::endl;


Aeroport::Aeroport(int size, string nom, Adresse ad){

	size_ = size;
	nom_ = nom;
	address = ad;
}



void Aeroport::display(){

	cout << "Name : " << nom_ << endl;
	cout << "Size : " << size_ << endl;
	address.display();

}



void Aeroport::addAirstrip(int length, int composition, int nummer){

	Airstrip a(length,composition,nummer);
	airstrip_.push_back(a);

}



void Aeroport::displayAllAirstrip(){

	cout << "[INFO] Taille du vecteur airstrip " << airstrip_.size() << endl;
	for (int i = 0; i < airstrip_.size(); i++ ){
	
		cout << " i => " << i << endl;
		airstrip_[i].displayInformation();
		cout << endl;
	
	}

}



void Aeroport::comparAirstrip(int a, int b){

	airstrip_[a].compareComposition(airstrip_[b]);
	airstrip_[a].compareLength(airstrip_[b]);
	airstrip_[a].compareNummer(airstrip_[b]);

}


Aeroport::~Aeroport(){
}
