#pragma once

#include <iostream>
#include <vector>
#include <string>

using namespace std;

class Address;


class Address {
public:
	Address(int number, string street, string postalCode, string town);
	void afficher();
	~Address();
private:
	int number_;
	string street_;
	string postalCode_;
	string town_;
};



class Bien{
public:
	Bien(int taille);
	void virtual afficher()=0;
	virtual ~Bien()=0;
protected:
	int taille_;
};



class Maison : public Bien{
public:
	Maison(bool mitoyen, int taille);
	void afficher();
	~Maison();
private:
	bool mitoyen_;
};



class Appartement : public Bien{
public:
	Appartement(int nombreEtage, int taille);
	void afficher();
	~Appartement();
private:
	int nombreEtage_;
};



// abstraite
class Personne{
public:
	Personne(string nom, string prenom);
	void afficher();
	virtual ~Personne()=0;
private:
	string nom_;
	string prenom_;
};



class Employe : public Personne{
public:
	Employe(int nombreHeure, string nom, string prenom);
	void afficher();
	~Employe();
private:
	int nombreHeure_;
};



//abstraite
class Client : public Personne{
public:
	Client(string nom, string prenom, int number, string telephone);
	void afficher();
	virtual ~Client()=0;
private:
	int number_;
	string telephone_;
};




class Proprietaire : virtual public Client{
public:
	Proprietaire(string nom, string prenom, int number, string telephone, string type);
	// Envoi d'un bien par référence, une classe abstraite n'autorise pas le bien direct !
	void ajouterBien(Bien *b);
	virtual void afficher();
	~Proprietaire();
protected:
	string type_;
	vector<Bien *> bien_;
};



class Locataire : virtual public Client{
public:
	Locataire(string nom, string prenom, int number, string telephone, double salaire);
	virtual void afficher();
	~Locataire();
protected:
	double salaire_;
};



class LocProp : public Proprietaire, public Locataire {
public:
	LocProp(string nom, string prenom, int number, string telephone, double salaire, string type);
	void afficher();
	~LocProp();

};



class Ai {
public:
	Ai(string nom, Address adr, string numeroTelephone);
	void ajouterBien(Bien *b);
	void ajouterPersonne(Personne *p);
	void afficher();
	void afficherBien();
	void afficherPersonne();
	void associerBienPersonne(Proprietaire *p, Bien *b);
	~Ai();
private:
	string nom_;
	Address adr_;
	string numeroTelephone_;
	vector<Bien *> bien_;
	vector<Personne *> personne_;
};

