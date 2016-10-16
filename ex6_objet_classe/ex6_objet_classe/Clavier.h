#pragma once
#include <iostream>
#include <string>


using namespace std;

class Clavier
{
public:
	Clavier();
	Clavier(string marque, short int nombreTouches, float prix);
	void afficherTouches();
	double afficherPrixAvecTva();
	double augmenterPrix();
	double diminuerPrix();
	static int getNombreStatic();
	~Clavier();
private :
	static int cptNombreObjet;
	string marque_;
	short int nombreTouche_;
	float prix_;
};

