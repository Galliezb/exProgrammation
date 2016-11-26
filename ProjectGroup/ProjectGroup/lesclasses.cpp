#include "lesclasses.h"

/**********************************/
/********* INIT STATIC ************/
/**********************************/
int Address::numberInstance_	= 0;
int Group::numberInstance_		= 0;
int School::numberInstance_		= 0;
int Building::numberInstance_	= 0;
int Room::numberInstance_		= 0;
int Course::numberInstance_		= 0;
int Person::numberInstance_		= 0;
int Barcode::numberInstance_	= 0;
int Advisor::numberInstance_	= 0;
int Director::numberInstance_	= 0;
int Secretary::numberInstance_	= 0;
int Teacher::numberInstance_	= 0;
int Student::numberInstance_	= 0;
int Hybrid::numberInstance_		= 0;
int Skill::numberInstance_		= 0;

/************************************/
/********** CLASS ADDRESS ***********/
/************************************/
Address::Address(int boxnumber, int number, int postalCode, string street, string town){
	boxnumber_ = boxnumber;
	number_ = number;
	postalCode_ = postalCode;
	street_ = street;
	town_ = town;
	numberInstance_++;
}

void Address::display(){

}

Display::Display(){
	// debug
	//cout << "Constructeur Display" << endl;

	// Handle de fenêtre ( https://msdn.microsoft.com/fr-fr/library/cc485739(v=vs.71).aspx )
	HWND console = GetConsoleWindow();
	// structure rectangle ( left, top, right, bottom => https://msdn.microsoft.com/en-us/library/a5ch4fda.aspx )
	RECT r;
	// on stock les dimensions de la fenêtre console dans le RECT
	GetWindowRect(console, &r);
	//MoveWindow(handle fenêtre, x, y, largeur, hauteur, bool_redimensionnement);
	MoveWindow(console, r.left, r.top, 1250, 600, TRUE);

}

bool Display::checkCinIntValidity(int min, int max, int valueToVerify){
	cout << "Min : " << min << endl << "Max :" << max << endl << "Valeur : " << valueToVerify << endl;
	// Empty buffer manually ( why fflush and cin.clear() work not ? )
	while (cin.get() != '\n') {}
	system("pause");
	return false;
}

void Display::displayStart(){
	
	cout << "-------------------------------------------------------------------------------------------------------------------------------------------------------" << endl;
	cout << "-                                                              TEST DU LOGICIEL,                                                                      -" << endl;
	cout << "-                                                           CHOISSISSEZ UN ROLE SVP                                                                   -" << endl;
	cout << "-------------------------------------------------------------------------------------------------------------------------------------------------------" << endl;
	pauseAtBottom(2);
	cout << "\t ----------------------------\t\t\t\t -----------------------------\t\t\t\t ----------------------" << endl;
	cout << "\t---                        ---\t\t\t\t---                         ---\t\t\t\t---                  ---" << endl;
	cout << "\t---  1 : Gerant du groupe  ---\t\t\t\t---  2 : Directeur d'ecole  ---\t\t\t\t---  3 : Secretaire  ---" << endl;
	cout << "\t---                        ---\t\t\t\t---                         ---\t\t\t\t---                  ---" << endl;
	cout << "\t ----------------------------\t\t\t\t -----------------------------\t\t\t\t ----------------------" << endl;
	// Hauteur = 35 lignes ( ici -3 -1 pour le message )
	pauseAtBottom(23);


}

void Display::pauseAtBottom(int cpt=0){
	for (int i = 0; i<cpt; i++){
		cout << endl;
	}
}

Display::~Display(){
	cout << "Deconstructeur Display" << endl;
}
