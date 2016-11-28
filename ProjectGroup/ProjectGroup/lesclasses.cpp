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



string Address::display(){

	string stringReturn;
	stringReturn += to_string(number_);
	stringReturn +=  " ";
	stringReturn += street_;
	stringReturn += ", ";
	if ( boxnumber_ != NULL ){
		stringReturn += "( BP ";
		stringReturn += to_string(boxnumber_);
		stringReturn += " )";
	}
	stringReturn += to_string(postalCode_);
	stringReturn += " ";
	stringReturn += town_;

	return stringReturn;

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
			cout << "*******************************************************************************************************************************************************" << endl;
			cout << "***                                             You need to enter a number in the good range please                                                 ***" << endl;
			cout << "*******************************************************************************************************************************************************" << endl;
			pauseAtBottom(31);
			break;
			
	}
	system("pause");
	system("cls");

}

void Display::fillFullLine(const char c){
	cout << c << setw(150) << setfill(c) << c << endl;
}

void Display::centerOutputString( string str ){

	int width = 150 - str.length();
	int first,sec;

	// espace avant et après
	first =  width / 2;
	sec =  width / 2;
	if ( !(width % 2 == 0) ) {
		// impair
		first++;
	}
	// J'adore l'espace nécessare au fonctionnement de setw et setFill
	cout << "-" << setw(first) << setfill(' ') << " " << str << setw(sec) << setfill(' ') << "-"<< endl;

}



void Display::menuStart(){

	fillFullLine('-');
	centerOutputString( string("TEST DU LOGICIEL,") );
	centerOutputString( string("CHOISSISSEZ UN ROLE SVP") );
	fillFullLine('-');

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

	fillFullLine('-');
	cout << "-                                                              GESTION DU GROUPE                                                                      -" << endl;
	fillFullLine('-');

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

	/*
	ofstream f;
	// file open in binary mode and app ( or app ? )
	
	f.open("advisor.txt", ios::binary | ios::out | ios::trunc);
	if(f.fail()){
		cerr<<"Fail _ Impossible de créer le fichier advisor.txt\n";
		exit(8);
	}
	if(f.bad()){
		cerr<<"Bad _ Impossible de créer le fichier pers.txt\n";
		exit(8);
	}
	f << setw(50) << "Bernard" << setw(50) << "RIGUELLE"<< setw(50) << 0<< setw(50) << 159 << setw(50) << 7000<< setw(50) << "Chaussee de Binche"<< setw(50) << "Mons"<< setw(50) << "Secretaire academique"<< setw(50) << "+32 (0)65 40 41 81"<< setw(50) << "+32 (0)65 34 04 52" << endl;
	f << setw(50) << "Stephanie" << setw(50) << "DEHOUCK" << setw(50) << 0 << setw(50) << 159 << setw(50) << 7000 << setw(50) << "Chaussee de Binche" << setw(50) << "Mons" << setw(50) << "Secretaire academique" << setw(50) << "+32 (0)65 40 41 76 (ou +32 (0)477 75 97 83)" << setw(50) << "+32 (0)65 34 04 52" << endl;
	f << setw(50) << "Maryse" << setw(50) << "LAMBERT" << setw(50) << 0 << setw(50) << 159 << setw(50) << 7000 << setw(50) << "Chaussee de Binche" << setw(50) << "Mons" << setw(50) << "Gestionnaire financiere et comptable" << setw(50) << "+32 (0)65 40 41 63" << setw(50) << "+32 (0)65 34 04 52" << endl;
	f << setw(50) << "Catherine" << setw(50) << "PREAT" << setw(50) << 0 << setw(50) << 159 << setw(50) << 7000 << setw(50) << "Chaussee de Binche" << setw(50) << "Mons" << setw(50) << "Gestionnaire administrative et juridique" << setw(50) << "+32 (0)65 40 41 80" << setw(50) << "+32 (0)65 34 04 52" << endl;
	f << setw(50) << "Michel" << setw(50) << "PETTEAU" << setw(50) << 0 << setw(50) << 159 << setw(50) << 7000 << setw(50) << "Chaussee de Binche" << setw(50) << "Mons" << setw(50) << "Directeur categorie Arts Appliques" << setw(50) << "+32 (0)65 40 41 43" << setw(50) << "inconnu" << endl;
	f << setw(50) << "Jean-Philippe" << setw(50) << "PINGOT" << setw(50) << 0 << setw(50) << 159 << setw(50) << 7000 << setw(50) << "Chaussee de Binche" << setw(50) << "Mons" << setw(50) << "Conseiller en prevention HELHa" << setw(50) << "+32 (0)496 12 55 74" << setw(50) << "+32 (0)65 34 04 52" << endl;
	f.close();
	*/
	

	ifstream fi;	
	fi.open("advisor.txt", ios::binary | ios::in);
	if ( fi.fail() ){
		cerr<<"Fail _ Impossible de créer le fichier advisor.txt\n";
		exit(9);
	}
	if ( fi.bad() ){
		cerr<<"Bad _ Impossible de créer le fichier advisor.txt\n";
		exit(9);
	}
	

	string line;
	while( getline( fi, line ) ){

		//cout << "LIGNE : " << line << endl; 

		string firstName,name,street,town,statut,tel,fax;
		int boxNumber,number,codePostal;

		/*
		cout << "**************************" << endl;
		cout << "Longueur : " << line.length();
		cout << "**************************" << endl;
		*/
		
		
		firstName = line.substr(0,50);
		// vire les espaces blancs avant la chaine de caractere
		firstName.erase(remove_if(firstName.begin(), firstName.end(), isspace), firstName.end());
		name = line.substr(50,50);
		name.erase(remove_if(name.begin(), name.end(), isspace), name.end());
		boxNumber = stoi(line.substr(100,50));
		number = stoi(line.substr(150,50));
		codePostal = stoi(line.substr(200,50));
		street = line.substr(250,50);
		street.erase(remove_if(street.begin(), street.end(), isspace), street.end());
		town = line.substr(300,50);
		town.erase(remove_if(town.begin(), town.end(), isspace), town.end());
		statut = line.substr(350,50);
		statut.erase(remove_if(statut.begin(), statut.end(), isspace), statut.end());
		tel = line.substr(400,50);
		tel.erase(remove_if(tel.begin(), tel.end(), isspace), tel.end());
		fax = line.substr(450,50);
		fax.erase(remove_if(fax.begin(), fax.end(), isspace), fax.end());
		
		
		cout << "prenom : " << firstName << endl; 
		cout << "name : " << name << endl; 
		cout << "boxNumber : " << boxNumber << endl; 
		cout << "number : " << number << endl; 
		cout << "codePostal : " << codePostal << endl; 
		cout << "street : " << street << endl; 
		cout << "town : " << town << endl; 
		cout << "tel : " << tel << endl; 
		cout << "fax : " << fax << endl;

		Person* a = new Advisor("Bernard","RIGUELLE",NULL,159,7000,"Chaussee de Binche","Mons","Secretaire academique","+32 (0)65 40 41 81","+32 (0)65 34 04 52");
		advisor_.push_back(a);

		

	}
	fi.close();

	// Pour gagner du temps pendant la présentation, enregisrement auto.
	// pointer for polymorphism ( Person is abstract )
	/*
	Person* a = new Advisor("Bernard","RIGUELLE",NULL,159,7000,"Chaussee de Binche","Mons","Secretaire academique","+32 (0)65 40 41 81","+32 (0)65 34 04 52");
	advisor_.push_back(a);

	a = new Advisor("Stephanie","DEHOUCK",NULL,159,7000,"Chaussee de Binche","Mons","Secretaire academique","+32 (0)65 40 41 76 (ou +32 (0)477 75 97 83)","+32 (0)65 34 04 52");
	advisor_.push_back(a);

	a = new Advisor("Maryse","LAMBERT",NULL,159,7000,"Chaussee de Binche","Mons","Gestionnaire financiere et comptable","+32 (0)65 40 41 63","+32 (0)65 34 04 52");
	advisor_.push_back(a);

	a = new Advisor("Catherine","PREAT",NULL,159,7000,"Chaussee de Binche","Mons","Gestionnaire administrative et juridique","+32 (0)65 40 41 80","+32 (0)65 34 04 52");
	advisor_.push_back(a);

	a= new Advisor("Michel","PETTEAU",NULL,159,7000,"Chaussee de Binche","Mons","Directeur categorie Arts Appliques","+32 (0)65 40 41 43","inconnu");
	advisor_.push_back(a);

	a = new Advisor("Jean-Philippe","PINGOT",NULL,159,7000,"Chaussee de Binche","Mons","Conseiller en prevention HELHa","+32 (0)496 12 55 74","+32 (0)65 34 04 52");
	advisor_.push_back(a);
	*/
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

	Display::pauseAtBottom(26);

	system("pause");
	system("cls");

	for each (Person *a in advisor_){

		system("cls");
		cout << "-------------------------------------------------------------------------------------------------------------------------------------------------------" << endl;
		cout << "-                                                         INFORMATION GROUP HELHA                                                                     -" << endl;
		cout << "-------------------------------------------------------------------------------------------------------------------------------------------------------" << endl;
		a->display();
		Display::pauseAtBottom(25);
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

Advisor::Advisor( string name , string firstName , int boxNumber , int number , int postalCode , string street , string town , string statut, string telefoon, string fax)
		: Person( name , firstName , boxNumber , number , postalCode , street , town ){

	statut_ = statut;
	telefoon_ = telefoon;
	fax_ = fax;

	numberInstance_++;

}

void Advisor::display(){

	cout << "* Nom :\t\t\t" << name_ << endl;
	cout << "* Prenom : \t\t" << firstName_ << endl;
	cout << "* Statut :\t\t" << statut_ << endl;
	cout << "* Telephone :\t\t" << telefoon_ << endl;
	cout << "* Fax : \t\t" << fax_ << endl;
	cout << "* Adresse : \t\t" << address_.display() << endl;
	

}

Advisor::~Advisor(){
	// debug
	// cout << "Deconstruct instance Advisor" << endl;
}

School::~School(){
	// debug
	// cout << "Deconstruct instance School" << endl;
}

School::School( string type , string name ){
	type_ = type;
	name_ = name;
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
