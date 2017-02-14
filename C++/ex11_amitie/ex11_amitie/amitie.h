#pragma once

#include <string>
#include <iostream>

using namespace std;

class Vetement {
public:
	Vetement(int taille=0, string couleur="rouge", string type="robe");
	void afficher();
	friend void comparer(Vetement &a, Vetement &b);
	~Vetement();
private:
	int taille_;
	string couleur_;
	string type_;
};

void comparer(Vetement &a, Vetement &b);

