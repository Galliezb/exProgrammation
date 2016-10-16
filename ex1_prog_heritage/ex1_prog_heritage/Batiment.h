#pragma once

class Batiment
{
public:
	Batiment();
	Batiment(int age, int nombrePiece);
	void afficher();
	void augmenterNombrePiece(int nbr);
	~Batiment();
protected:
	int age_;
	int nombrePiece_;
};

