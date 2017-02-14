#pragma once
#include <string>
#include "Adr.h"
using namespace std;
class Ai
{
public:
	Ai();
	~Ai();
	Adr adresse;
	string nom;
	string tel;

	void ajouterBien();
	void ajouterPersonne();
	void afficherTousLesBiens();
	void afficherToutesLesPeronnes();
	void associerUnBienAUnePersonne();
};

