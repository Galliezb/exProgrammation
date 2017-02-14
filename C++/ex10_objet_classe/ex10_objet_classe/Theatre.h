#pragma once
#include "Artiste.h"

class Theatre
{
public:
	Theatre();
	void afficherInfos();
	void ajouteArtiste(const Artiste& a);
	void afficherTousLesArtistes();
	~Theatre();
private:
	char* nom_;
	int indexActuel=0;
	Artiste artiste[];
};

