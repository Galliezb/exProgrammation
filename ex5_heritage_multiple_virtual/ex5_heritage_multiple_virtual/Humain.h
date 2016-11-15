#pragma once

#include <string>
#include <iostream>



using namespace std;

class Element{
public:
	Element(int identifiant=0);
	void afficher();
	~Element();
protected:
	int identifiant_;
};

class Humain : public virtual Element {
public:
	Humain(string nom, char genre, int age, int identifiant);
	void afficher();
	~Humain();
private:
	string nom_;
	char genre_;
	int age_;
};



class Machine : public virtual Element{
public :
	Machine(string type, int autonomie, int identifiant);
	void afficher();
	~Machine();

private:
	string type_;
	int autonomie_;
};


class Humanoide : public Humain, public Machine {
public:
	Humanoide(int taille, string matiere, string type, int autonomie, string nom, char genre, int age, int identifiant );
	void afficher();	
	~Humanoide();
private:
	int taille_;
	string matiere_;
};
