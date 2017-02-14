#pragma once
#include <string>
#include <vector>

#include "Adresse.h"
#include "Airstrip.h"

using std::string;
using std::vector;

class Aeroport
{
public:
	Aeroport(int size, string nom, Adresse ad);
	void display();
	void addAirstrip(int length, int composition, int nummer);
	void displayAllAirstrip();
	void comparAirstrip(int a, int b);
	~Aeroport();
private:
	string nom_;
	short int size_;
	Adresse address;
	vector<Airstrip> airstrip_;
};

