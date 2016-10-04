#include "Theatre.h"



Theatre::Theatre():nom_("Paul"){
}

void Theatre::afficherInfos(){
	cout << "Nom du theatre : " << nom_ << endl;
}

void Theatre::ajouteArtiste(const Artiste& a){
	artiste[indexActuel] = a;
	indexActuel++;
}

void Theatre::afficherTousLesArtistes(){
	for (int i = 0; i<indexActuel; i++){
		cout << "Artiste " << i << " : ";
		artiste[i].afficherInfos();
	}
}


Theatre::~Theatre(){
}
