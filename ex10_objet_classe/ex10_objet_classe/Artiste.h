#pragma once
#include <iostream>

using namespace std;

class Artiste
{
public:
	Artiste();
	Artiste(const Artiste&);
	void afficherInfos();
	int ajouterAge(int nbr = 1);
	bool comparer( const Artiste&,const Artiste& );
	~Artiste();
private:
	char* nom_;
	char* prenom_;
	short int age_;
};

