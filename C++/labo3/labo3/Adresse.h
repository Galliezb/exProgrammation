#pragma once

#include <string>

using std::string;

class Adresse
{
public:
	Adresse(int number=0, int postalCode=0,string street="", string town="");
	void display();
	~Adresse();
private:
	int number_,postalCode_;
	string street_,town_;

};

