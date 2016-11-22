#pragma once

#include <string>
#include <iostream>

using namespace std;


class Styliste;

class Vetement {
public:
	Vetement(int taille=0, string couleur="rouge", string type="robe");
	void afficher();
	// donne accès aux donné private pour la fonction comparer
	friend void comparer(Vetement &a, Vetement &b);
	// donne accès au méthode de la classe Styliste
	friend class Styliste;
	~Vetement();
private:
	int taille_;
	string couleur_;
	string type_;
};

void comparer(Vetement &a, Vetement &b);


class Styliste {
public:
	Styliste(string nom,int annee_experience);
	void afficher();
	void modifierTaille(Vetement &v, int taille);
	void modifierCouleur(Vetement &v, string couleur);
	void modifierType(Vetement &v, string type);
	~Styliste();
private:
	string nom_;
	int annee_experience_;
};

