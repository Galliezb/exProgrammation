#include "Humain.h"



Humain::Humain(string nom, char genre, int age, int identifiant) : Element(identifiant){
	cout << "Constructeur Humain" << endl;
	nom_ = nom;
	genre_ = genre;
	age_ = age;
}

void Humain::afficher(){
	cout << "Humain afficher() : " << endl;
	cout << "Nom : " << nom_ << endl;
	cout << "Genre : " << genre_ << endl;
	cout << "Age : " << age_ << endl;
}


Humain::~Humain(){
	cout << "Destructeur Humain" << endl;
}

Machine::Machine(string type, int autonomie, int identifiant) : Element(identifiant){
	cout << "Constructeur Machine" << endl;
	type_ = type;
	autonomie_ = autonomie;
}

void Machine::afficher(){

	cout << " Machine afficher() : " << endl;
	cout << "Type : " << type_ << endl;
	cout << "Atuonomie : " << autonomie_ << endl;

}

Machine::~Machine(){
	cout << "Destructeur Machine" << endl;
}

Humanoide::Humanoide(int taille, string matiere, string type, int autonomie, string nom, char genre, int age, int identifiant ):
	       Humain(nom, genre, age, identifiant),
	       Machine(type, autonomie, identifiant){
	cout << "Constructeur Humanoide" << endl;
	taille_=taille;
	matiere_ = matiere;
}

void Humanoide::afficher(){
	cout << "Humanoide afficher() : " << endl;
	cout << "Taille : " << taille_ << endl;
	cout << "Matiere : " << matiere_ << endl;
	Machine::afficher();
	Humain::afficher();
	//Element::afficher();
	/*
	ICI on profite de l'ambihuité pour definir deux fois l'identifiant
	au prix d'un double constructeur ( donc sans le virtual )
	cout << "Machine identifiant : " << endl << Machine::identifiant_ << endl;
	cout << "Humain identifiant : " << endl << Humain::identifiant_ << endl;
	cout << "stockage different dans la classe mere ?" << endl;
	cout << "modification identifiant dans Human. Nouvelle valeure = 5" << endl;
	Humain::identifiant_ = 5;
	cout << "Machine identifiant : " << endl << Machine::identifiant_ << endl;
	cout << "Humain identifiant : " << endl << Humain::identifiant_ << endl;
	*/
	// Le virtual va supprimé l'ambihuité sur l'appel de la variable classe mère.
	cout << "Element protected identifiant_ : " << endl << "Identifiant : " << identifiant_ << endl;
}

Humanoide::~Humanoide(){
	cout << "Destructeur Humanoide" << endl;
}

Element::Element(int identifiant){
	cout << "Constructeur Element" << endl;
	identifiant_ = identifiant;
}

void Element::afficher(){
	cout << "Element Afficher() :" << endl;
	cout << "identifiant : " << identifiant_ << endl;
}

Element::~Element(){
	cout << "Deconstructeur Element" << endl;
}
