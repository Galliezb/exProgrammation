#include "recette.h"


Ingredient::Ingredient(string nature, int calorie, int glucide, int proteine, int lipide, string quantite){
	nature_ = nature;
	calorie_ = calorie;
	glucide_ = glucide;
	proteine_ = proteine;
	lipide_ = lipide;
	quantite_ = quantite;
}

Ingredient::~Ingredient(){
	cout << "Deconstructeur Ingredient" << endl;
}

Recette::Recette(int code,string nom,string typePlat,int niveau,int tpsPreparation,int tpsCuisson,string modeCuisson,string explication,Restaurant &r, vector<Ingredient>& v){
	code_ = code;
	nom_ = nom;
	typePlat_ = typePlat;
	niveau_ = niveau;
	tpsPreparation_ = tpsPreparation;
	tpsCuisson_ = tpsCuisson;
	modeCuisson_ = modeCuisson;
	explication_ = explication;

	restaurant_.push_back(r);
	ingredients_ = v;
}

Recette::~Recette(){
	cout << "Deconstructeur recette" << endl;
}


Restaurant::Restaurant(string nom, string rue, int numero, string ville, int codePostal){
	nom_ = nom;
	rue_ = rue;
	numero_ = numero;
	ville_ = ville;
	codePostal_ = codePostal;
}

Restaurant::~Restaurant(){
	cout << "Deconstructeur de restaurant" << endl;
}


iostream& operator<< (iostream& o, Recette& r){
	//  info recette
	o << "Recette : " << r.nom_ << endl;
	o << "Type de plat : " << r.typePlat_ << endl;
	o << "Niveau : " << r.niveau_ << endl;
	o << "Temps de preparation : " << r.tpsPreparation_ << endl;
	o << "Temps de cuisson : " << r.tpsCuisson_ << endl;
	o << "Mode de cuisson : " << r.modeCuisson_ << endl;
	o << "Explication : " << r.explication_ << endl;

	// quels sont les ingrédients ?
	o << "Liste ingrédients : " << endl;
	for each (Ingredient ingr in r.ingredients_){
		
		o << ingr.
	}

	// quels restaurant la font ?
	for each (Restaurant r in r.restaurant_){
		// TODO afficher les restaux
	}

	return o;
}

/*
iostream& operator<< (iostream& i, Ingredient& ingr){
	i << ingr.quantite_ << ingr.nature_;
	return i;
}
iostream& operator<< (iostream& i, Restaurant& r){
	i  << r.nom_ << " ( Adresse : " << r.numero_ << "," << r.rue_ << r.codePostal_ << r.ville_ << ")";
	return i;
}
*/