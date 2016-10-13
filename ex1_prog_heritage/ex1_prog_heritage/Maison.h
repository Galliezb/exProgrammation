#pragma once
#include "Batiment.h"
class Maison : public Batiment {
public:
	Maison();
	Maison(int nombreMurMitoyen, bool avecJardin, int age, int nombrePiece );
	void afficher();
	int augmenterNombre(int nbr);
	~Maison();
protected:
	int nombreMurMitoyen_;
	bool avecJardin_;
};

