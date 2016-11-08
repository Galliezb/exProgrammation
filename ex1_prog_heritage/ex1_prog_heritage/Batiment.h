#pragma once

class Batiment
{
public:
	Batiment();
	Batiment(int age, int nombrePiece);
	virtual void afficher();
	virtual int augmenterNombre(int nbr);
	~Batiment();
protected:
	int age_;
	int nombrePiece_;
};

