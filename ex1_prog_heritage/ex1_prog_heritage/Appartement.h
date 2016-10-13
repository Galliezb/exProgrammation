#pragma once
#include "Batiment.h"
class Appartement : public Batiment {
public:
	Appartement();
	Appartement(int nombreEtage, int superficie, int age, int nombrePiece);
	void afficher();
	int augmenterNombre(int nbr);
	~Appartement();
protected:
	int nombreEtage_;
	int superficie_;
};

