#pragma once
#include <string>
#include <iostream>
#include <map>
#include <vector>
#include <iterator>

using namespace std;

class Departement;
class Personne;
class Enseignant;

/************* SALLE *******************/
class Salle{
public:
	Salle( string nom, int nombrePlaces );
	~Salle();
private:
	string nom_;
	int nombrePlaces_;
};

/************* MATIERE *******************/
class Matiere{
public:
	Matiere( int code, string libelle);
	~Matiere();
	void addSalle(Salle s);
private:
	int code_;
	string libelle_;
	Salle salle_;
};

/************* COLLEGE *******************/
class College{
public:
	College( string n, string url );
	~College();
	void addDepartement( int code, string nom );
	void afficher();
	vector<Departement>* getDepartement();
private:
	string nom_;
	string url_;
	vector<Departement> dpt;
};
/************* NOTE *******************/
class Note{
public:
	Note( double noteControle, int codeMatiere );
	double getNote();
	int getCodeMatiere();
	~Note();
private:
	double noteControle_;
	int codeMatiere_;
};
/************* DATE *******************/
class Date{
public:
	Date();
	Date(int jour,int mois,int annee);
	~Date();
private:
	int jour_;
	int mois_;
	int annee_;
};


/************* DEPARTEMENT *******************/
class Departement{
public:
	Departement( int code, string nom );
	void afficher();
	~Departement();
	void ajouterPersonne( Personne *pers );
private:
	int code_;
	string nom_;
	vector<Personne*> personne_;
	multimap<string,Enseignant*> multi_;
};

/************* PERSONNE *******************/
class Personne{
public:
	Personne( string nom, string prenom, string teleponne, string mail );
	void afficher();
	~Personne();
protected:
	string nom_;
	string prenom_;
	string telephone_;
	string mail_;
};

/************* ETUDIANT *******************/
class Etudiant : public Personne {
public:
	Etudiant( string nom, string prenom, string teleponne, string mail , int anneeEntree);
	~Etudiant();
	void ajouterNote(Note n);
	double calculerMoyenneParMatiere( int codeMatiere );
	double calculerMoyenneGenerale();
	void afficherNbrEtudiant();
	void afficher();
private:
	int anneeEntree_;
	static int nbrEtudiant;
	vector<Note> note_;
};

/************* ENSEIGNANT *******************/
class Enseignant : public Personne {
public : 
	Enseignant( string nom, string prenom, string teleponne, string mail );
	void afficher();
	~Enseignant();
	void addMatiere(Matiere mat);
private:
	Date date_;
	vector<Matiere> mat_;
};
