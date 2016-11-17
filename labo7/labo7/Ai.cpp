#include "Ai.h"


/********************* CLASS ADDRESS *********************/
Address::Address(int number, string street, string postalCode, string town){

	number_ = number;
	street_ = street;
	postalCode_ = postalCode;
	town_ = town;

	cout << "Constructeur objet Adresse" << endl;

}

void Address::afficher(){
	cout << "****** Adresse *****" << endl;
	cout << "Numero :" << number_ << endl;
	cout << "Rue :" << street_ << endl;
	cout << "Code Postal :" << postalCode_ << endl;
	cout << "Ville :" << town_ << endl;
}

Address::~Address(){

	cout << "Destruction of object Address" << endl;

}


Ai::Ai(){
}


Ai::~Ai(){
}

Bien::Bien(int taille){

	taille_ = taille;
	cout << "Constructeur objet Bien" << endl;

}

Maison::Maison(bool mitoyen, int taille) : Bien(taille){
	mitoyen_ = mitoyen;
	cout << "Constructeur objet Maison ( classe mere : Bien )" << endl;
}

void Maison::afficher(){
	cout << "***** BIEN ( maison ) *****" << endl;
	cout << "Est-elle mitoyenne : " << (mitoyen_ ? "Oui" : "Non") << endl;
	cout << "Taille : " << taille_ << endl;
}

Maison::~Maison(){
	cout << "Deconstructeur objet Maison ( classe mere  : Bien )" << endl;
}

Appartement::Appartement(int nombreEtage, int taille) : Bien(taille){
	nombreEtage_ = nombreEtage;
	cout << "Constructeur objet Appartement ( classe mere : Bien )" << endl;
}

void Appartement::afficher(){
	cout << "***** BIEN ( appartement ) *****" << endl;
	cout << "Nombre étage : " << nombreEtage_ << endl;
	cout << "Taille : " << taille_ << endl;
}

Appartement::~Appartement(){
	cout << "Deconstructeur objet appartement ( classe mere : BIen )" << endl;
}

Personne::Personne(string nom, string prenom){
	nom_ = nom;
	prenom_= prenom;
	cout << "Constructeur objet Personne" << endl;
}

void Personne::afficher(){
	cout << "***** Personne ***** " << endl;
	cout << "nom : " << nom_ << endl;
	cout << "prenom : " << prenom_ << endl;
}

Employe::Employe(int nombreHeure, string nom, string prenom) : Personne(nom,prenom){
	nombreHeure_ = nombreHeure;
	cout << "Constructeur objet Employe" << endl;
}

void Employe::afficher(){
	cout << "***** Employe *****" << endl;
	Personne::afficher();
	cout << "Nombre heure : " << nombreHeure_ << endl;
}

Employe::~Employe(){
	cout << "Deconstructeur objet Employe ( classe mere Personne )" << endl;
}

Client::Client(string nom, string prenom, int number, string telephone) : Personne(nom,prenom){
	cout << "Constructeur de Client" << endl;
	number_ = number;
	telephone_ = telephone;
}

void Client::afficher(){
	Personne::afficher();
	cout << "***** Client *****" << endl;
	cout << "Numbero : " << number_ << endl;
	cout << " Telephone : " << telephone_ << endl;
}

Proprietaire::Proprietaire(string nom, string prenom, int number, string telephone, string type) : Client(nom,prenom,number,telephone){
	cout << "Constructeur objet Proprietaire" << endl;
	type_=type;
}


void Proprietaire::ajouterBien(const Bien &b){
	bien_.push_back(b);
}

void Proprietaire::afficher(){
	Client::afficher();
	cout << "***** Proprietaire ***** " << endl;
	cout << "Type : " << type_ << endl;	
	cout << "***** Bien du prorprietaire *****" << endl;
	for each (Bien b in bien_){
		b.afficher();
	}
}

Proprietaire::~Proprietaire(){
	cout << "Descructeur objet proprietaire" << endl;
}

Locataire::Locataire(string nom, string prenom, int number, string telephone, double salaire) : Client(nom,prenom,number,telephone) {
	cout << "Constructeur objet Locataire" << endl;
	salaire_ = salaire;
}

void Locataire::afficher(){
	Client::afficher();
	cout << "***** Locataire *****" << endl;
	cout << "Salaire : " << salaire_;
}

Locataire::~Locataire(){
	cout << "Deconstructeur objet locataire" << endl;
}

LocProp::LocProp(string nom, string prenom, int number, string telephone, double salaire, string type) : 
	     Locataire(nom,prenom,number,telephone,salaire), 
	     Proprietaire(nom,prenom,number,telephone,type),
		 Client (nom,prenom,number,telephone){

}
