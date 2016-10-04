#pragma once
#include <iostream>
#include <string>


using namespace std;

class Clavier
{
public:
	Clavier();
	void initialiser(string marque, short int nombreTouches, float prix);
	void afficherTouches();
	double afficherPrixAvecTva();
	~Clavier();
private :
	string marque_;
	short int nombreTouche_;
	float prix_;
};

