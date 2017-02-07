#include "lesclasses.h"

int Etudiant::nbrEtudiant=0;

College::College( string n, string url ){

	nom_ = n;
	url_ = url;

}

College::~College(){
	// cout << "Deconstructeur College" << endl;
}

void College::addDepartement(int code, string nom){
	dpt.push_back(Departement(code,nom));
}

void College::afficher(){
	cout << "nom : " << nom_ << endl;
	cout << "url : " << url_ << endl;

	for each (Departement d in dpt){
		d.afficher();
	}
}

vector<Departement>* College::getDepartement(){
	return &dpt;
}

Departement::Departement(int code, string nom){
	code_ = code;
	nom_ = nom;
}

void Departement::afficher(){
	cout << "nom : " << nom_ << endl;
	cout << "code departement : " << code_ << endl;

}

Departement::~Departement(){
	// cout << "Deconstructeur Departement" << endl;
}

void Departement::ajouterPersonne( Personne *pers ){

	//multi_.insert

}

Personne::Personne(string nom, string prenom, string teleponne, string mail){

	nom_ = nom;
	prenom_ = prenom;
	telephone_ = teleponne;
	mail_ = mail;

}

void Personne::afficher(){
	cout << "nom : " << nom_ << endl;
	cout << "prenom : " << prenom_ << endl;
	cout << "Mail : " << mail_ << endl;
	cout << "tel : " << telephone_ << endl;
}

Personne::~Personne(){
	// cout << "Deconstructeur Personne" << endl;
}

Etudiant::Etudiant(string nom, string prenom, string teleponne, string mail, int anneeEntree):Personne(nom, prenom, teleponne, mail){
	anneeEntree_ = anneeEntree;
	nbrEtudiant++;
}

Etudiant::~Etudiant(){
	// cout << "Deconstructeur Etudiant" << endl;
	nbrEtudiant--;
}

void Etudiant::ajouterNote(Note n){

	note_.push_back( n );

}

double Etudiant::calculerMoyenneParMatiere( int codeMatiere ){

	int verif = 0;

	double moyenne = 0;
	for each (Note n in note_){
		if ( n.getCodeMatiere() ==  codeMatiere ){
			moyenne+= n.getNote();
		}
	}
	moyenne = moyenne / note_.size();

	return moyenne;
}

double Etudiant::calculerMoyenneGenerale(){

	double moyenne = 0;
	for each (Note n in note_){
		moyenne+= n.getNote();
	}
	moyenne = moyenne / note_.size();

	return moyenne;
}

void Etudiant::afficherNbrEtudiant(){
	cout << "Nombre etudiant" << nbrEtudiant << endl;
}

void Etudiant::afficher(){
	cout << "nom : " << nom_ << endl;
	cout << "prenom : " << prenom_ << endl;
	cout << "Mail : " << mail_ << endl;
	cout << "tel : " << telephone_ << endl;
}

Enseignant::Enseignant(string nom, string prenom, string teleponne, string mail):Personne(nom, prenom, teleponne, mail){
}

void Enseignant::afficher(){
	Personne::afficher();
}

Enseignant::~Enseignant(){
	//cout << "Deconstructeur Enseignant" << endl;
}

void Enseignant::addMatiere(Matiere mat){
	mat_.push_back(mat);
}

Salle::Salle(string nom="nondefinie", int nombrePlaces=40){

	nom_ = nom;
	nombrePlaces_ = nombrePlaces;

}

Salle::~Salle(){
}

Matiere::Matiere(int code, string libelle){
	code_ = code;
	libelle_ = libelle;
	//salle_ = 0;
}

Matiere::~Matiere(){
}

void Matiere::addSalle(Salle s){
	salle_ = s;
}

Note::Note( double noteControle, int codeMatiere ){
	noteControle_ = noteControle;
	codeMatiere_ = codeMatiere;
}

double Note::getNote(){
	return noteControle_;
}

int Note::getCodeMatiere(){
	return codeMatiere_;
}

Note::~Note(){
}

Date::Date(){
	jour_ = 1;
	mois_ = 1;
	annee_ = 1970;
}

Date::Date(int jour=1, int mois=1, int annee=1970){
	jour_ = jour;
	mois_ = mois;
	annee_ = annee;
}

Date::~Date(){
}
