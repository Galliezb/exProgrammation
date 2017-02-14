#include "Humain.h"



Humain::Humain(string nom, char genre, int age){
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

Machine::Machine(string type, int autonomie){
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

Humanoide::Humanoide(int taille, string matiere, string type, int autonomie, string nom, char genre, int age ):Humain(nom, genre, age),Machine(type, autonomie){
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
}

Humanoide::~Humanoide(){
	cout << "Destructeur Humanoide" << endl;
}
