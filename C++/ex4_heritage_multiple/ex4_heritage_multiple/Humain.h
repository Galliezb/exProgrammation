#pragma once

#include <string>
#include <iostream>



using namespace std;

class Humain {
public:
	Humain(string nom, char genre, int age);
	void afficher();
	~Humain();
private:
	string nom_;
	char genre_;
	int age_;
};



class Machine{
public :
	Machine(string type, int autonomie);
	void afficher();
	~Machine();
	
private:
	string type_;
	int autonomie_;
};


class Humanoide : public Humain, public Machine {
public:
	Humanoide(int taille, string matiere, string type, int autonomie, string nom, char genre, int age );
	void afficher();
	~Humanoide();
private:
	int taille_;
	string matiere_;
};