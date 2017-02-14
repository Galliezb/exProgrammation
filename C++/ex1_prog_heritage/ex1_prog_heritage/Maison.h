#pragma once
#include "Batiment.h"
class Maison : public Batiment {
public:
	Maison();
	Maison(int nombreMurMitoyen, bool avecJardin, int age, int nombrePiece );
	//  Ex 1
	//void afficher();
	// ex2
	virtual void afficher();
	int augmenterNombre(int nbr);
	~Maison();
protected:
	int nombreMurMitoyen_;
	bool avecJardin_;
};

