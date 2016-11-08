#pragma once
#include "Batiment.h"
class Appartement : public Batiment {
public:
	Appartement();
	Appartement(int nombreEtage, int superficie, int age, int nombrePiece);
	//  Ex 1
	//void afficher();
	// ex2
	virtual void afficher();
	int augmenterNombre(int nbr);
	~Appartement();
protected:
	int nombreEtage_;
	int superficie_;
};

