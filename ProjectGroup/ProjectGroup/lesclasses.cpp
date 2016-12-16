#pragma once
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

string Address::getAddressForStream(){
	ostringstream stream;
	stream	<< setw(50) << boxnumber_ 
			<< setw(50) << number_ 
			<< setw(50) << postalCode_ 
			<< setw(50) << street_
			<< setw(50) << town_;

	return stream.str();
}

Address::~Address(){
	// debug
	//cout << "Deconstruct instance Address" << endl;
	numberInstance_--;
}



Display::Display(){
}



void Display::error(){

	system("cls");

	fillFullLine('*');
	centerOutputString("You need to enter a number in the good range please");
	fillFullLine('*');
	pauseAtBottom(31);

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

void Display::instruction(string str){

	fillFullLine('-');
	centerOutputString( str );
	fillFullLine('-');
	pauseAtBottom(31);


}

void Display::menuStart(){
	system("cls");
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

	// clean console
	system("cls");
	// title window
	fillFullLine('-');
	centerOutputString( string("GESTION DU GROUPE") );
	fillFullLine('-');
	// space between title and menu
	pauseAtBottom(2);

	// build menu
	vector<string> vector;
	vector.push_back( string("QUITTER") );
	vector.push_back( string("AFFICHER INFORMATION") );
	vector.push_back( string("AFFICHER LES ECOLES") );
	vector.push_back( string("AJOUTER UN CONSEILLER") );
	vector.push_back( string("SUPPRIMER UN CONSEILLER") );
	vector.push_back( string("AJOUTER UNE ECOLE") );
	vector.push_back( string("SUPPRIMER UNE ECOLE") );
	// push menu to build and display
	Treatment::makeMenu(vector);
	Display::pauseAtBottom(22);

}

int Display::menuDirector(){

	int valueReturn;

	do {

		// clean console
		system("cls");
		// title window
		fillFullLine('-');
		centerOutputString( string("GESTION DU DIRECTEUR") );
		fillFullLine('-');
		// space between title and menu
		pauseAtBottom(2);

		// build menu
		vector<string> vector;
		vector.push_back( string("QUITTER") );
		vector.push_back( string("AFFICHER LES EMPLOYES") );
		vector.push_back( string("VIRER UNE SECRETAIRE") );
		vector.push_back( string("VIRER UN PROFESSEUR") );
		vector.push_back( string("EMBAUCHER UNE SECRETAIRE") );
		vector.push_back( string("EMBAUCHER UN PROFESSEUR") );
		// push menu to build and display
		Treatment::makeMenu(vector);
		Display::pauseAtBottom(23);

		cin >> valueReturn;

	} while ( !Treatment::checkCinIntValidity(0,5,valueReturn) );

	return valueReturn;


}

int Display::menuSecretary(){

	int valueReturn;

	// clean console
	system("cls");
	// title window
	fillFullLine('-');
	centerOutputString( string("GESTION DES SECRETAIRES") );
	fillFullLine('-');
	// space between title and menu
	pauseAtBottom(2);

	// build menu
	vector<string> vector;
	vector.push_back( string("QUITTER") );
	// push menu to build and display
	Treatment::makeMenu(vector);
	Display::pauseAtBottom(28);

	cin >> valueReturn;

	return valueReturn;

}

int Display::menuComputerScientist(){

	int valueReturn;

	// clean console
	system("cls");
	// title window
	fillFullLine('-');
	centerOutputString( string("GESTION DE L'INFORMATICIEN") );
	fillFullLine('-');
	// space between title and menu
	pauseAtBottom(2);

	// build menu
	vector<string> vector;
	vector.push_back( string("QUITTER") );
	// push menu to build and display
	Treatment::makeMenu(vector);
	Display::pauseAtBottom(28);

	cin >> valueReturn;

	return valueReturn;

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

Group::Group(string name, string telephone, string fax, string mail, string website, Address& address ){

	name_ = name;
	telephone_ = telephone;
	fax_ = fax;
	mail_ = mail;
	website_ = website;
	address_ = address;

	numberInstance_++;


	/****************** LOAD ADVISOR FROM FILE *********************/
	ifstream fi;	
	fi.open( string("fileSave/advisor.txt"), ios::in);
	if ( fi.fail() || fi.bad() ){ exit(0); }
	

	string line;
	while( getline( fi, line ) ){

		//cout << "LIGNE : " << line << endl; 

		string firstName,name,street,town,status,tel,fax;
		int boxNumber,number,codePostal;		
		
		firstName = Treatment::deleteWhiteSpace( line, 0, 50);
		name = Treatment::deleteWhiteSpace( line, 50, 50);

		boxNumber = stoi(line.substr(100,50));
		number = stoi(line.substr(150,50));
		codePostal = stoi(line.substr(200,50));

		street = Treatment::deleteWhiteSpace( line, 250, 50);
		town = Treatment::deleteWhiteSpace( line, 300, 50);
		status = Treatment::deleteWhiteSpace( line, 350, 50);
		tel = Treatment::deleteWhiteSpace( line, 400, 50);
		fax = Treatment::deleteWhiteSpace( line, 450, 50);

		// Pour gagner du temps pendant la présentation, enregisrement auto depuis un fichier
		// pointer for polymorphism ( Person is abstract )
		Person* a = new Advisor( name, firstName, boxNumber, number, codePostal, street, town, status, tel, fax);
		advisor_.push_back(a);

		

	}
	fi.close();
	/****************** LOAD SCHOOL FROM FILE *********************/
	fi.open("fileSave/school.txt", ios::in);
	if ( fi.fail() || fi.bad() ){ exit(1); }


	while( getline( fi, line ) ){

		//cout << "LIGNE : " << line << endl; 

		string name,type;		

		name = Treatment::deleteWhiteSpace( line, 0, 50);
		type = Treatment::deleteWhiteSpace( line, 50, 50);

		// win time, loaf from files
		School* a = new School( name, type );
		school_.push_back(a);

	}
	fi.close();

}

void Group::addAdvisor( string name , string firstName , int boxNumber , int number , int postalCode , string street , string town , string status , string telephone , string fax ){

	// Add to vector
	Person* advisor = new Advisor(name,firstName,boxNumber,number,postalCode,street,town,status,telephone,fax);
	advisor_.push_back(advisor);

	regenerateFile( string("fileSave/advisor.txt") );

	system("cls");
	Display::fillFullLine('*');
	Display::centerOutputString("CONSEILLER AJOUTE");
	Display::fillFullLine('*');
	Display::pauseAtBottom(31);
	system("pause");


}

void Group::addSchool(School* sch){

	school_.push_back( sch );

	system("cls");
	Display::fillFullLine('*');
	Display::centerOutputString("ECOLE ENREGISTREE");
	Display::fillFullLine('*');
	Display::pauseAtBottom(31);

	regenerateFile( string("fileSave/school.txt") );

	system("pause");

}

void Group::delAdvisor(int numberOfLine){

	advisor_.erase( advisor_.begin() + numberOfLine );
	// TODO : test if good element is delete
	//advisor_.erase[numberOfLine];

	system("cls");
	Display::fillFullLine('*');
	Display::centerOutputString("CONSEILLER SUPPRIME");
	Display::fillFullLine('*');
	Display::pauseAtBottom(31);
	system("pause");

	regenerateFile( string("fileSave/advisor.txt") );

}

void Group::delSchool(int numberOfLine){

	school_.erase( school_.begin() + numberOfLine );

	regenerateFile( string("fileSave/school.txt") );

	system("cls");
	Display::fillFullLine('*');
	Display::centerOutputString("ECOLE SUPPRIME");
	Display::fillFullLine('*');
	Display::pauseAtBottom(31);
	system("pause");


}

void Group::displayInfo(){
	
	system("cls");
	
	Display::fillFullLine('-');
	Display::centerOutputString("INFORMATION DU GROUP");
	Display::fillFullLine('-');

	cout << "* Nom : \t\t" << name_ << endl;
	cout << "* Telephone : \t\t" << telephone_ << endl;
	cout << "* Fax : \t\t" << fax_ << endl;
	cout << "* Mail : \t\t" << mail_ << endl;
	cout << "* Site Web : \t\t" << website_ << endl;

	Display::pauseAtBottom(26);

	system("pause");
	system("cls");

	for each (Person *a in advisor_){

		system("cls");
		Display::fillFullLine('-');
		Display::centerOutputString("INFORMATION GROUP HELHA");
		Display::fillFullLine('-');
		a->display();
		Display::pauseAtBottom(25);
		system("pause");

	}

}

void Group::displaySchool(){

	system("cls");
	Display::fillFullLine('-');
	Display::centerOutputString("LES ECOLES APPARTENANT AU GROUPE");
	Display::fillFullLine('-');

	int i = 0;
	for each (School *sch in school_){
		cout << "* " << sch->getNameAndStatus() << endl;
		i++;

	}

	Display::pauseAtBottom(35-4-i);
	system("pause");

}

Group::~Group(){
	// debug
	// cout << "Deconstruct instance Group" << endl;

	// new = need delete !
	for each (School *s in school_){
		delete(s);
	}

	// new = need delete !
	for each (Person *a in advisor_){
		a->~Person();
		delete(a);
	}

	numberInstance_--;

}

void Group::regenerateFile( string nameTxtFile ){

	// save in file
	// ofstream  -> ios::out set by default
	ofstream f;
	// file open in binary mode and TRUNC for empty the file
	f.open( nameTxtFile , ios::trunc);

	if( f.fail() || f.bad() ){ exit(2); }


	if ( nameTxtFile == "fileSave/advisor.txt" ){
		for each (Person *pers in advisor_){
			f << pers->stringForWriteFile() << endl;
		}
	} else if ( nameTxtFile == "fileSave/school.txt" ){
		for each (School *sch in school_){
			f << sch->stringForWriteFile() << endl;
		}
	}

	f.close();

}

int Group::displayAdvisorForDelete(){

	int numberToDelete;
	bool goodOrRetry = false;

	system("cls");

	Display::fillFullLine('-');
	Display::centerOutputString("CHOISSISSEZ LE NUMERO DU CONSEILLER A SUPPRIMER");
	Display::fillFullLine('-');
	Display::pauseAtBottom(2);
	
	// build menu
	vector<string> vector;

	int i=0;
	
	for each (Person *pers in advisor_){

		// return string, and save for build menu
		vector.push_back( pers->getFullName() );
		i++;
	}
	
	// push menu to build and display
	Treatment::makeMenu(vector);
	Display::pauseAtBottom(35-6-i);

	// Tss you can't troll !
	do {
		cin >> numberToDelete;
		goodOrRetry = Treatment::checkCinIntValidity(0,i,numberToDelete);
	} while ( !goodOrRetry );

	return numberToDelete;


}

School* Group::displaySchoolForSelect(){


	int numberSelected = -1;
	bool goodOrRetry = false;

	system("cls");

	Display::fillFullLine('-');
	Display::centerOutputString("CHOISSISSEZ LE NUMERO DE L ECOLE A SELECTIONNER");
	Display::fillFullLine('-');
	Display::pauseAtBottom(2);

	// build menu
	vector<string> vector;

	int i=0;

	for each (School *sch in school_){

		// return string, and save for build menu
		vector.push_back( sch->getNameAndStatus() );

		i++;
	}

	// push menu to build and display
	Treatment::makeMenu(vector);
	Display::pauseAtBottom(35-6-i);

	// Tss you can't troll !
	do {
		cin >> numberSelected;
		goodOrRetry = Treatment::checkCinIntValidity(0,i,numberSelected);
	} while ( !goodOrRetry );

	system("cls");
	Display::fillFullLine('*');
	Display::centerOutputString("VOUS ETES DESORMAIS LE DIRECTEUR DE CETTE ECOLE");
	Display::fillFullLine('*');
	Display::pauseAtBottom(31);

	// is realy essential ?
	//school_[numberSelected].displayDirector();
	
	// return the school for manipulation
	return school_[numberSelected];
	

}

int Group::displaySchoolForDelete(){

	int numberToDelete;
	bool goodOrRetry = false;

	system("cls");

	Display::fillFullLine('-');
	Display::centerOutputString("CHOISSISSEZ LE NUMERO DE L ECOLE A SUPPRIMER");
	Display::fillFullLine('-');
	Display::pauseAtBottom(2);

	// build menu
	vector<string> vector;

	int i=0;

	for each (School *sch in school_){

		// return string, and save for build menu
		vector.push_back( sch->getNameAndStatus() );

		i++;
	}

	// push menu to build and display
	Treatment::makeMenu(vector);
	Display::pauseAtBottom(35-6-i);

	// Tss you can't troll !
	do {
		cin >> numberToDelete;
		goodOrRetry = Treatment::checkCinIntValidity(0,i,numberToDelete);
	} while ( !goodOrRetry );

	return numberToDelete;
}

Person::Person( string name , string firstName , int boxNumber , int number , int postalCode , string street , string town , string status = "nostatus" ){
	// debug
	//cout << "Constructeur person : " << name << " - " << firstName << endl;
	// debug
	//system("pause");

	name_ = name;
	firstName_ = firstName;
	status_ = status;

	address_ = Address( boxNumber , number , postalCode , street , town );
	numberInstance_++;
}

string Person::getFullName(){
	return string(firstName_ + " " + name_);
}

string Person::getStatus(){
	return string(status_);
}

Person::~Person(){
	// debug
	// cout << "Deconstruct instance Person" << endl;
	numberInstance_--;
}

Advisor::Advisor( string name , string firstName , int boxNumber , int number , int postalCode , string street , string town , string function, string telephone, string fax )
		: Person( name , firstName , boxNumber , number , postalCode , street , town, string("advisor") ){

	function_ = function;
	telephone_ = telephone;
	fax_ = fax;

	numberInstance_++;

}

void Advisor::display(){

	cout << "* Nom :\t\t\t" << name_ << endl;
	cout << "* Prenom : \t\t" << firstName_ << endl;
	cout << "* Fonction :\t\t" << function_ << endl;
	cout << "* Telephone :\t\t" << telephone_ << endl;
	cout << "* Fax : \t\t" << fax_ << endl;
	cout << "* Adresse : \t\t" << address_.display() << endl;
	

}

string Advisor::stringForWriteFile(){

	ostringstream stream;
	stream << setw(50) << firstName_ 
		<< setw(50) << name_ 
		<< address_.getAddressForStream()
		<< setw(50) << status_
		<< setw(50) << telephone_
		<< setw(50) << fax_
		<< setw(50) << status_
		<< endl;

	return stream.str();

}

Advisor::~Advisor(){
	// debug
	// cout << "Deconstruct instance Advisor" << endl;

	numberInstance_--;
}

void School::displayTotalPersonPerType(){

	int director=0,secretary=0,student=0,teacher=0,hybrid=0;

	for each (Person* p in person_){

		if ( p->getStatus() == "director" ){
			director++;
		} else if ( p->getStatus() == "secretary" ){
			secretary++;
		} else if ( p->getStatus() == "teacher" ){
			teacher++;
		} else if ( p->getStatus() == "student" ){
			student++;
		} else if ( p->getStatus() == "hybrid" ){
			hybrid++;
		}

	}

	Display::fillFullLine('-');
	Display::centerOutputString( string("LISTE DES PERSONNES OCCUPANTS L'ECOLE") );
	Display::fillFullLine('-');

	cout << "Directeur :\t" << director << endl;
	cout << "Secretaire :\t" << secretary << endl;
	cout << "Enseignants :\t" << teacher << endl;
	cout << "Etudiant :\t" << student << endl;
	cout << "hybrid :\t" << hybrid << endl;
	Display::pauseAtBottom(26);
}

void School::addPerson(Teacher * t){

	// teacher in save in Person vector
	Person* p = t;
	person_.push_back(p);

	// empty + rewrite file
	regenerateFilePerson();

}

void School::addPerson(Secretary * s){

	// Secretary in save in Person vector
	Person* p = s;
	person_.push_back(p);

	// empty + rewrite file
	regenerateFilePerson();

}

string School::getNameAndStatus(){
	return string(name_ + " ( " + type_ + " ) ");
}

Person* School::getYourDirector(){

	Person* ptrPerson = NULL;

	for each (Person* pers in person_){
		
		if ( pers->getStatus() == "director" ){
		
			ptrPerson = pers;
			break;

		}

	}

	return ptrPerson;

}

string School::stringForWriteFile(){

	ostringstream stream;
	stream << setw(50) << name_ << setw(50) << type_;

	return stream.str();

}

School::~School(){
	// debug
	//cout << "Deconstruct instance School" << endl;

	for each ( Person *pers in person_ ){
		delete pers;
	}

	for each(Building *build in building_ ){
		delete build;
	}

	numberInstance_--;

}

void School::reloadFromFile(){

	// save in file
	// ifstream  -> ios::int set by default ( read activate by default )
	ifstream file;

	string filename = "fileSave/person_school_" + Treatment::getAlphaNumeric(this->name_) + '_' + Treatment::getAlphaNumeric(this->type_) + ".txt";
	file.open( filename );

	cout << "Debug Acces file : " << filename << endl << "fs::exists(filename) : " << fs::exists(filename) << endl;

	
	
	// only if file exist. No file, nothing to load
	if ( fs::exists(filename) ){
		cout << "Le fichier existe" << endl;
	} else {
		cout << "Le fichier n'existe pas" << endl;
	}

	
	if ( fs::exists(filename) ){

		cout << "Condition : OK" << "( " << this->name_ << " )" << endl;
		system("pause");

		string line;
		while( getline( file, line ) ){

			// DATA PERSON + TYPE ( director, secretary etc... )	

			string firstName,name,street,town,status;
			int seniority,hoursToWork,boxNumber,number,postalCode;		

			// who are you ?
			status = Treatment::deleteWhiteSpace( line, 0, 50);

			if ( status == "director" ){
			
			} else if ( status == "secretary" ){

			} else if ( status == "student" ){

			} else if ( status == "teacher" ){

				//cout << "Debug : Teacher Found " << endl;

				firstName = Treatment::deleteWhiteSpace( line, 50, 50);
				name = Treatment::deleteWhiteSpace( line, 100, 50);

				hoursToWork = stoi(line.substr(150,50));
				seniority = stoi(line.substr(200,50));
				boxNumber = stoi(line.substr(250,50));
				number = stoi(line.substr(300,50));
				postalCode = stoi(line.substr(350,50));

				street = Treatment::deleteWhiteSpace( line, 400, 50);
				town = Treatment::deleteWhiteSpace( line, 300, 50);

				Person* t = new Teacher( name , firstName , hoursToWork , seniority , boxNumber , number , postalCode , street, string("teacher"));

				// TODO add skills

				person_.push_back(t);

		
			} else if ( status == "hybrid" ){

			}	


			// pointer for polymorphism ( Person is abstract )
			//Person* a = new Director( name, firstName, boxNumber, number, postalCode, street, town, string("director") );
			//this->person_.push_back(a);



		}
		file.close();
		//cout << "FIN Condition : OK" << "( " << this->name_ << " )" << endl;
		//system("pause");
	}
	

}

void School::regenerateFilePerson(){

	/**************** SAVE VECTOR PERSON ****************/

	// save in file
	ofstream file;

	string filename = "fileSave/person_school_" + Treatment::getAlphaNumeric(this->name_) + '_' + Treatment::getAlphaNumeric(this->type_) + ".txt";

	file.open( filename , ios::trunc);
	if( file.fail() || file.bad() ){ exit(4); }

	for each (Person *pers in person_){

		if ( pers->getStatus() == "director" ){
		
			file << pers->stringForWriteFile();

		} else if ( pers->getStatus() == "secretary" ){

			file << pers->stringForWriteFile();

		} else if ( pers->getStatus() == "student" ){

			file << pers->stringForWriteFile();

		} else if ( pers->getStatus() == "teacher" ){

			file << pers->stringForWriteFile();

		} else if ( pers->getStatus() == "hybrid" ){

			file << pers->stringForWriteFile();

		}

	}

	file.close();

}

School::School(){
	// debug
	// cout << "Construc School by default" << endl;
	name_ = "emptyObject";
	type_ = "emptyObject";
	numberInstance_++;
}

School::School( string type , string name ){
	type_ = type;
	name_ = name;
	numberInstance_++;

	reloadFromFile();

}

Building::Building(int numberFloor, Address & address){

	numberFloor_ = numberFloor_;
	address_ = address;

	numberInstance_++;

}

Building::~Building(){
	// debug
	// cout << "Deconstruct instance Building" << endl;
	numberInstance_--;
}

Room::Room(int area, int numberPlace){

	area_ = area;
	numberPlace_ = numberPlace;

	numberInstance_++;

}

Room::~Room(){
	// debug
	// cout << "Deconstruct instance Room" << endl;
	numberInstance_--;
}

Treatment::Treatment(){
	// debug
	// cout << "Construct Treatment" << endl;
}

bool Treatment::checkCinIntValidity(int min, int max, int valueToVerify){

	// debug
	//cout << "Min : " << min << endl << "Max :" << max << endl << "Valeur : " << valueToVerify << endl;
	//system("pause");

	emptyBuffer();

	if ( valueToVerify < min || valueToVerify > max ){
		Display::error();
		return false;
	} else {
		return true;
	}

}

string Treatment::deleteWhiteSpace(string str, int start, int end){

	str = str.substr( start, end );
	// string.erase => Erases part of the string, reducing its length ( http://www.cplusplus.com/reference/string/string/erase/) 
	str.erase(0, str.find_first_not_of(" "));

	return str;

}

void Treatment::emptyBuffer(){

	// Empty buffer manually ( why fflush and cin.clear() not enough ? )
	cin.clear();
	while (cin.get() != '\n') { continue; }

}

void Treatment::makeMenu(vector<string> vect){

	int max = 0, i = 0;

	for each (string myStr in vect){

		if ( max < myStr.length() ){ max = myStr.length(); }

	}


	int width = 150 - max - 13;
	for each (string myStr in vect){

		int difference = max - myStr.length();
		string display;
		// debug
		//cout << "Max : " << max << endl;
		// debug
		//cout << "myStr.length() : " << myStr.length() << endl;
		// debug
		//cout << "difference : " << difference << endl;

		display.append("**   ");
		display.append( to_string(i) );
		display.append(" : ");
		display.append(myStr);

		for (int i = 0; i<difference; i++){
			display.append(" ");
		}

		display.append("   **");

		Display::centerOutputString(display);
		i++;

	}


}

string Treatment::getAlphaNumeric(string str){

	// replace all no alpha numeric character in string by _
	for ( auto & c : str ) {
		if ( ! isalnum( c ) ) c = '-';
	}
	return str;

}

Treatment::~Treatment(){
	// debug
	// cout << "Deconstruct Treatment" << endl;
}

Director::Director(string name, string firstName, int boxNumber, int number, int codePostal, string street, string town, string status = "director")
		 :Person( name , firstName , boxNumber , number , codePostal , street , town , status){

	numberInstance_++;

}

void Director::display(){

	Display::fillFullLine('-');
	Display::centerOutputString("DIRECTEUR DE L'ECOLE");
	Display::fillFullLine('-');

	cout << "Nom : \t\t\t" << name_ << endl;
	cout << "Prenom : \t\t" << firstName_ << endl;
	cout << "Adresse : \t\t" << address_.display() << endl;
	cout << "****** COMPETENCE(S) ******" << endl;
	for each (Skill* s in skill_){
		s->display();
	}

}

string Director::stringForWriteFile(){
	
	ostringstream ios;	
	// data from director
	ios << setw(50) << status_ 
		<< setw(50) << firstName_
		<< setw(50) << name_
		<< address_.getAddressForStream()
		<< ';';
	// data from skill
	for each (Skill* s in skill_){
		ios << s->stringForWriteFile();
	}
	ios << ';' ;
	// data from course to follow = none
	ios << ';' ;
	// data from course to give = none
	ios << ';' ;
	return ios.str();
}

Director::~Director(){
	// debug
	// cout << "Deconstruct director by default" << endl;
}

Course::Course(){
	// debug
	// cout << "Construct Course by default" << endl;
}

string Course::display(){

	string ret;
	ret += entiteld_;
	ret += " ( ";
	ret += hoursRequire_;
	ret += " heures )";

	return ret;
}

string Course::stringForWriteFile(){

	string str('|' + entiteld_ + '&');
	str += hoursRequire_;

	return str;

}

Course::~Course(){
	// debug
	// cout << "Deconstruct course by default" << endl;
	numberInstance_--;
}

void School::displayDirector(){

	for each(Person* pers in person_ ){
	
		if ( pers->getStatus() == "director "){
			cout << "Nom : " << pers->getFullName() << endl;
		}

	}

}

void School::displayPerson( string who ){

	for each(Person* pers in person_ ){

		if ( pers->getStatus() == who || who == "" ){
			cout << "[ " << pers->getStatus() << " ] : " << pers->getFullName() << endl;
		}

	}

}

Teacher::Teacher(string name, string firstName, int hoursTodo, int seniority, int boxNumber, int number, int postalCode, string street, string town)
		:Person( name , firstName , boxNumber , number , postalCode , street , town, string("teacher") ){
	hoursToDo_ = hoursTodo;
	seniority_ = seniority;
	numberInstance_++;
}


void Teacher::display(){

	cout << "Nom : \t\t\t" << name_ << endl;
	cout << "Prenom : \t\t" << firstName_ << endl;
	cout << "Adresse : \t\t" << address_.display() << endl;
	cout << "Prestation semaine : " << hoursToDo_ << endl;
	cout << "Anciennete : " << seniority_ << endl;
	cout << endl;
	cout << "Competences possedees :" << endl;
	for each (Skill* s in skill_){
		s->display();
	}
	cout << endl;
	cout << "Attribué aux cours suivant : " << endl;
	for each (Course* c in courseToGive_){
		c->display();
	}
}

string Teacher::stringForWriteFile(){

	ostringstream ios;	
	// data Teacher
	ios << setw(50) << status_ 
		<< setw(50) << firstName_
		<< setw(50) << name_
		<< setw(50) << hoursToDo_
		<< setw(50) << seniority_
		<< address_.getAddressForStream();
	ios << ';';
	// data skill
	for each (Skill* s in skill_){
		ios << s->stringForWriteFile();
	}
	ios << ';';
	// data course to follow = none
	ios << ';';
	// data course to give
	for each (Course* c in courseToGive_){
		ios << c->stringForWriteFile();
	}
	ios << ';';
	return ios.str();

}

Teacher::~Teacher(){

	// debug
	// cout << "Deconstruct Teacher" << endl;

	for each (Course* c in courseToGive_){
		delete c;
	}

	for each (Skill* s in skill_){
		delete s;
	}

	numberInstance_--;

}


Skill::Skill(string entiteld, int salaryBonus){

	entiteld_ = entiteld;
	salaryBonus_ = salaryBonus;
	numberInstance_++;

}

string Skill::stringForWriteFile(){

	string str( "|" + entiteld_ + "&");
	str += salaryBonus_ ;

	return string();
}

void Skill::display(){

	cout << "' " << entiteld_ << " ' pour un bonus salarial de " << salaryBonus_ << endl;

}

Skill::~Skill(){
	// debug
	// cout << "Deconstruct Skill" << endl;

	numberInstance_--;
}

Secretary::Secretary(string name, string firstName, int hoursToWork, int boxNumber, int number, int postalCode, string street, string town)
		  :Person( name , firstName , boxNumber , number , postalCode , street , town, string("secretary") ){

	hoursToWork_ = hoursToWork;
	numberInstance_++;

}

void Secretary::display(){

	cout << "Nom : \t\t\t" << name_ << endl;
	cout << "Prenom : \t\t" << firstName_ << endl;
	cout << "Adresse : \t\t" << address_.display() << endl;
	cout << "Prestation semaine : " << hoursToWork_ << endl;

}

string Secretary::stringForWriteFile(){
	
	ostringstream ios;	
	// data secretary
	ios << setw(50) << status_ 
		<< setw(50) << firstName_
		<< setw(50) << name_
		<< setw(50) << hoursToWork_
		<< address_.getAddressForStream();
	ios << ';';
	// skill = none
	ios << ';';
	// course to follow = none
	ios << ';';
	// course to give = none
	ios << ';';
	return ios.str();

}

Secretary::~Secretary(){

	numberInstance_--;

}

Student::Student(string name, string firstName, int percentageOfGlanding, int percentageOfSucces, int boxNumber, int number, int postalCode, string street, string town)
		:Person( name , firstName , boxNumber , number , postalCode , street , town, string("student") ){

	percentageOfGlanding_ = percentageOfGlanding;
	percentageOfSucces_ = percentageOfSucces;

	numberInstance_++;
}

void Student::display(){

	cout << "Nom : \t\t\t" << name_ << endl;
	cout << "Prenom : \t\t" << firstName_ << endl;
	cout << "Adresse : \t\t" << address_.display() << endl;
	cout << "% de glandage : " << percentageOfGlanding_ << "%" << endl;
	cout << "% de reussite : " << percentageOfSucces_ << "%" << endl;

	for each (Course* c in courseToFollow_){
		c->display();
	}

}

string Student::stringForWriteFile(){
	
	ostringstream ios;	
	// data student
	ios << setw(50) << status_ 
		<< setw(50) << firstName_
		<< setw(50) << name_
		<< setw(50) << percentageOfGlanding_
		<< setw(50) << percentageOfSucces_
		<< address_.getAddressForStream();
	ios << ';';
	// skill = none
	ios << ';';
	// course to follow
	for each (Course* c in courseToFollow_){
		ios << c->stringForWriteFile();
	}
	ios << ';';
	// course to give = none;
	ios << ';';
	return ios.str();

}

Student::~Student(){
	numberInstance_--;
}

Hybrid::Hybrid(string name, string firstName, int hoursTodo, int seniority, int boxNumber, int number, int postalCode, string street, string town, int percentageOfGlanding, int percentageOfSucces)
	   :Teacher( name, firstName, hoursTodo , seniority , boxNumber, number, postalCode, street, town )
	   ,Student( name, firstName, percentageOfGlanding , percentageOfSucces , boxNumber, number, postalCode, street, town ){



}

void Hybrid::display(){

	cout << "Nom : \t\t\t" << Person::name_ << endl;
	cout << "Prenom : \t\t" << Person::firstName_ << endl;
	cout << "Adresse : \t\t" << Person::address_.display() << endl;
	cout << "Prestation semaine : " << hoursToDo_ << endl;
	cout << "Anciennete : " << seniority_ << endl;
	cout << endl;
	cout << "Competences possedees :" << endl;
	for each (Skill* s in skill_){
		s->display();
	}
	cout << endl;
	cout << "Donne les cours suivant : " << endl;
	for each (Course* c in courseToGive_){
		c->display();
	}
	cout << "Suit les cours suivant : " << endl;
	for each (Course* c in courseToFollow_){
		c->display();
	}


}

string Hybrid::stringForWriteFile(){

	ostringstream ios;	
	// data Teacher
	cout << "Informations : " << endl;
	ios << setw(50) << Person::status_ 
		<< setw(50) << Person::firstName_
		<< setw(50) << Person::name_
		<< setw(50) << hoursToDo_
		<< setw(50) << seniority_
		<< setw(50) << percentageOfGlanding_
		<< setw(50) << percentageOfSucces_
		<< setw(50) << Person::address_.getAddressForStream();
	ios << ';';
	// data skill
	cout << "Les competences : " << endl;
	for each (Skill* s in skill_){
		ios << s->stringForWriteFile();
	}
	ios << ';';
	// data course to follow
	cout << "Les cours a suivre : " << endl;
	for each (Course* s in courseToFollow_){
		ios << s->stringForWriteFile();
	}
	ios << ';';
	// data course to give
	cout << "Les cours a donner : " << endl;
	for each (Course* c in courseToGive_){
		ios << c->stringForWriteFile();
	}
	ios << ';';
	return ios.str();

}

Hybrid::~Hybrid(){
	numberInstance_--;
}
