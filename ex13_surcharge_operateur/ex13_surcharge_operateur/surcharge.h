#pragma once

#include <string>
#include <iostream>
#include <vector>

using namespace std;

class Polynome {
public:
	Polynome(int degre,int tabInt[]);
	void afficher();
	friend Polynome operator+(Polynome &a, Polynome &b);
	~Polynome();
private:
	int degre_;
	int* ptrInt_;
};

