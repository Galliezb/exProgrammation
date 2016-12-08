#pragma once

#include <string>
#include <iostream>
#include <vector>

using namespace std;

class Polynome {
public:
	Polynome();
	Polynome(int degre,int tabInt[]);
	void afficher();
	friend Polynome operator+( const Polynome &a , const Polynome &b );
	~Polynome();
private:
	int degre_;
	int* ptrTabInt_;
};

