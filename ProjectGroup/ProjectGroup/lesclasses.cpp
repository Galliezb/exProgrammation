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
Address::Address(int boxnumber=0, int number=0, int postalCode=0, string street="no street", string town="no town"){
	boxnumber_ = boxnumber;
	number_ = number;
	postalCode_ = postalCode;
	street_ = street;
	town_ = town;
	numberInstance_++;
}



void Address::display(){

	cout << street_ << "," << number_;

	if ( boxnumber_ != NULL ){
		cout << "( BP " << boxnumber_ << " )";
	}

	cout << endl;
	cout << postalCode_ << " " << town_ << endl;

}

Address::~Address(){
	// debug
	//cout << "Deconstruct instance Address" << endl;
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



void Display::checkCinIntValidity(int min, int max, int valueToVerify){

	// debug
	//cout << "Min : " << min << endl << "Max :" << max << endl << "Valeur : " << valueToVerify << endl;
	
	emptyBuffer();
	if ( valueToVerify < min || valueToVerify > max ){
		error( Error::number );
	}

}



void Display::emptyBuffer(){

	// Empty buffer manually ( why fflush and cin.clear() not enough ? )
	cin.clear();
	while (cin.get() != '\n') { continue; }

}



void Display::error( Error error ){

	system("cls");

	switch ( error ){

		case Error::number :
			cout << "Test check apres number" << endl;
			cout << "*******************************************************************************************************************************************************" << endl;
			cout << "***                                             You need to enter a number in the good range please                                                 ***" << endl;
			cout << "*******************************************************************************************************************************************************" << endl;
			pauseAtBottom(31);
			break;
			
	}
	system("pause");
	system("cls");

}



void Display::menuStart(){
	
	cout << "-------------------------------------------------------------------------------------------------------------------------------------------------------" << endl;
	cout << "-                                                              TEST DU LOGICIEL,                                                                      -" << endl;
	cout << "-                                                           CHOISSISSEZ UN ROLE SVP                                                                   -" << endl;
	cout << "-------------------------------------------------------------------------------------------------------------------------------------------------------" << endl;
	pauseAtBottom(2);
	cout << "   ----------------------------\t\t ----------------------------\t\t -----------------------------\t\t ----------------------" << endl;
	cout << "  ---                        ---\t---                        ---\t\t---                         ---\t\t---                  ---" << endl;
	cout << "  ---  0 : Quitter           ---\t---  1 : Gerant du groupe  ---\t\t---  2 : Directeur d'ecole  ---\t\t---  3 : Secretaire  ---" << endl;
	cout << "  ---                        ---\t---                        ---\t\t---                         ---\t\t---                  ---" << endl;
	cout << "   ----------------------------\t\t ----------------------------\t\t -----------------------------\t\t ----------------------" << endl;
	// Hauteur = 35 lignes ( ici -3 -1 pour le message )
	pauseAtBottom(23);


}

void Display::menuGroup(){
	cout << "-------------------------------------------------------------------------------------------------------------------------------------------------------" << endl;
	cout << "-                                                              GESTION DU GROUPE                                                                      -" << endl;
	cout << "-------------------------------------------------------------------------------------------------------------------------------------------------------" << endl;
	pauseAtBottom(2);
	cout << "   ----------------------------\t\t ----------------------------\t\t -----------------------------\t\t ----------------------" << endl;
	cout << "  ---                        ---\t---                        ---\t\t---                         ---\t\t---                  ---" << endl;
	cout << "  ---  0 : QUITTER           ---\t---  1 : AFFICHER INFO     ---\t\t---                         ---\t\t---                  ---" << endl;
	cout << "  ---                        ---\t---                        ---\t\t---                         ---\t\t---                  ---" << endl;
	cout << "   ----------------------------\t\t ----------------------------\t\t -----------------------------\t\t ----------------------" << endl;
	pauseAtBottom(24);
}



void Display::pauseAtBottom(int cpt=0){
	for (int i = 0; i<cpt; i++){
		cout << endl;
	}
}



Display::~Display(){
	// debug
	//cout << "Deconstructeur Display" << endl;
}

Group::Group(string name, string telefoon, string fax, string mail, string website, Address& address ){

	name_ = name;
	telefoon_ = telefoon;
	fax_ = fax;
	mail_ = mail;
	website_ = website;
	address_ = address;

	numberInstance_++;

	// Advisor
	/******************* !!!!!!!!!!!!!!!! *******************/
	// pointer for polymorphism
	Person* a = new Advisor("Bernard","RIGUELLE",NULL,159,7000,"Chaussee de Binche","Mons","Secretaire academique","+32 (0)65 40 41 81","+32 (0)65 34 04 52");
	advisor_.push_back(a);

	Person* b = new Advisor("Stephanie","DEHOUCK",NULL,159,7000,"Chaussee de Binche","Mons","Secretaire academique","+32 (0)65 40 41 76 (ou +32 (0)477 75 97 83)","+32 (0)65 34 04 52");
	advisor_.push_back(b);

	Person* c = new Advisor("Maryse","LAMBERT",NULL,159,7000,"Chaussee de Binche","Mons","Gestionnaire financiere et comptable","+32 (0)65 40 41 63","+32 (0)65 34 04 52");
	advisor_.push_back(c);

	Person* d = new Advisor("Catherine","PREAT",NULL,159,7000,"Chaussee de Binche","Mons","Gestionnaire administrative et juridique","+32 (0)65 40 41 80","+32 (0)65 34 04 52");
	advisor_.push_back(d);

	Person* e = new Advisor("Michel","PETTEAU",NULL,159,7000,"Chaussee de Binche","Mons","Directeur categorie Arts Appliques","+32 (0)65 40 41 43","inconnu");
	advisor_.push_back(e);

	Person* f = new Advisor("Jean-Philippe","PINGOT",NULL,159,7000,"Chaussee de Binche","Mons","Conseiller en prevention HELHa","+32 (0)496 12 55 74","+32 (0)65 34 04 52");
	advisor_.push_back(f);
}

void Group::displayInfo(){
	
	system("cls");
	
	cout << "-------------------------------------------------------------------------------------------------------------------------------------------------------" << endl;
	cout << "-                                                         INFORMATION GROUP HELHA                                                                     -" << endl;
	cout << "-------------------------------------------------------------------------------------------------------------------------------------------------------" << endl;

	cout << "* Nom : \t\t" << name_ << endl;
	cout << "* Telephone : \t\t" << telefoon_ << endl;
	cout << "* Fax : \t\t" << fax_ << endl;
	cout << "* Mail : \t\t" << mail_ << endl;
	cout << "* Site Web : \t\t" << website_ << endl;
	
	system("pause");
	system("cls");

	for each (Person *a in advisor_){

		system("cls");
		cout << "-------------------------------------------------------------------------------------------------------------------------------------------------------" << endl;
		cout << "-                                                         INFORMATION GROUP HELHA                                                                     -" << endl;
		cout << "-------------------------------------------------------------------------------------------------------------------------------------------------------" << endl;
		a->display();
		system("pause");

	}

}

Group::~Group(){
	// debug
	// cout << "Deconstruct instance Group" << endl;

	// new = need delete !
	for each (Person *a in advisor_){
		delete(a);
	}

}

Advisor::Advisor( string name , string firstName , int boxNumber , int number , int postalCode , string street , string town , string statut, string telefoon, string fax)
		: Person( name , firstName , boxNumber , number , postalCode , street , town ){

	statut_ = statut;
	telefoon_ = telefoon;
	fax_ = fax;

	numberInstance_++;

}

void Advisor::display(){

	cout << "* Nom :\t\t " << name_ << endl;
	cout << "* Prenom : \t\t" << firstName_ << endl;
	cout << "* Statut :\t\t " << statut_ << endl;
	cout << "* Telephone :\t\t" << telefoon_ << endl;
	cout << "* Fax : \t\t" << fax_ << endl;
	cout << "* Adresse : \t\t" << endl;
	address_.display();

}

Advisor::~Advisor(){
	// debug
	// cout << "Deconstruct instance Advisor" << endl;
}

Person::Person( string name , string firstName , int boxNumber , int number , int postalCode , string street , string town ){
	// debug
	//cout << "Constructeur person : " << name << " - " << firstName << endl;
	// debug
	//system("pause");

	name_ = name;
	firstName_ = firstName;

	address_ = Address( boxNumber , number , postalCode , street , town );

}

Person::~Person(){
	// debug
	// cout << "Deconstruct instance Person" << endl;
}

School::~School(){
	// debug
	// cout << "Deconstruct instance School" << endl;
}

School::School( string level ){
	level_ = level;
}

Building::Building(int numberFloor, Address & address){

	numberFloor_ = numberFloor_;
	address_ = address;

	numberInstance_++;

}

Building::~Building(){
	// debug
	// cout << "Deconstruct instance Building" << endl;
}

Room::Room(int area, int numberPlace){

	area_ = area;
	numberPlace_ = numberPlace;

	numberInstance_++;

}

Room::~Room(){
	// debug
	// cout << "Deconstruct instance Room" << endl;
}
