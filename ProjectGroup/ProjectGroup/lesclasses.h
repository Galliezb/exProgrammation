#include <string>
#include <iostream>
#include <iomanip>
#include <sstream>
#include <fstream>
#include <vector>
#include <Windows.h>
#include <algorithm>
#include <experimental/filesystem> // file exists ?

using namespace std;
namespace fs = std::experimental::filesystem; 

class Teacher;
class Student;
class Secretary;
class Director;
class School;

/************************************/
/********** CLASS ADDRESS ***********/
/************************************/
class Address {
public:
	Address( int boxnumber, int number, int postalCode,
			 string street, string town );
	string display();
	static void displayNumberOfInstance();
	string getAddressForStream();
	~Address();
private:
	int boxnumber_;
	static int numberInstance_;
	int number_;
	int postalCode_;
	string street_;
	string town_;
};


/************************************/
/*********  CLASS COURSE  ***********/
/************************************/
class Course{
public:
	Course( string entiteld , int hoursRequire );
	string display();
	static void displayNumberOfInstance();
	string stringForWriteFile();
	~Course();
private:
	string entiteld_;
	int hoursRequire_;
	static int numberInstance_;
};



/************************************/
/*********  CLASS PERSON  ***********/
/************************************/
class Person{
public:
	Person( string name , string firstName , int boxNumber , int number , int postalCode , string street , string town , string status );
	virtual void display()=0;
	static void displayNumberOfInstance();
	string getFullName();
	string getStatus();
	virtual string stringForWriteFile()=0;
	virtual ~Person();
protected:
	Address address_;
	string name_ , firstName_ , status_;
private:
	static int numberInstance_;
};



/************************************/
/*********  CLASS SCHOOL  ***********/
/************************************/
class School{
public:
	School();
	School( string type , string name );
	void addDirector(bool replace);
	void addPerson(Teacher* t);
	void addPerson(Secretary* s);
	void addPerson(Director * d, bool replace);
	void addPerson(Student * d);
	void addPerson( string dirTolistOfStudent );
	void delPerson(Person *p);
	static void displayNumberOfInstance();
	void displayDirector();
	void displayPerson( string who = "" );
	Person* displayPersonForSelect( string who = "" );
	void displayTotalPersonPerType();
	string getNameAndStatus();
	Person* getYourDirector();
	string stringForWriteFile();
	~School();

private:
	string type_, name_;
	static int numberInstance_;
	// pointer for polymorphism
	vector<Person*> person_;

	void reloadFromFile();
	void regenerateFilePerson();
};


/************************************/
/********* CLASS ADVISOR ***********/
/************************************/
class Advisor : public Person {
public:
	Advisor( string name , string firstName , int boxNumber , int number , int postalCode , string street , string town , string function , string telephone , string fax );
	void display();
	string stringForWriteFile();
	~Advisor();
private:
	string function_ , telephone_ , fax_ ;
};



/************************************/
/*********  CLASS GROUP   ***********/
/************************************/
class Group{
public:
	Group(string name, string telephone, string fax, string mail, string website, Address& address );
	void addAdvisor( string name , string firstName , int boxNumber , int number , int postalCode , string street , string town , string status , string telephone , string fax );
	void addSchool( School* sch );
	void delAdvisor( int numberOfLine );
	void delSchool( int numberOfLine );
	int displayAdvisorForDelete();
	static void displayNumberOfInstance();
	School* displaySchoolForSelect();
	int displaySchoolForDelete();
	void displayInfo();
	void displaySchool();
	~Group();
private:
	string name_ , telephone_ , fax_, mail_, website_;
	Address address_;
	vector<School*> school_;
	vector<Person*> advisor_;
	static int numberInstance_;

	void regenerateFile( string nameTxtFile );
};



/************************************/
/*********   CLASS SKILL  ***********/
/************************************/
class Skill{
public:
	Skill( string entiteld , int salaryBonus );
	static void displayNumberOfInstance();
	string stringForWriteFile();
	void display();
	~Skill();
private:
	string entiteld_;
	static int numberInstance_;
	int salaryBonus_;
};


/************************************/
/********* CLASS DIRECTOR ***********/
/************************************/
class Director : public Person {
public:
	Director(string name, string firstName, int boxNumber, int number, int codePostal, string street, string town, string status );
	void addSkill( string entiteld , int salaryBonus );
	void display();
	string stringForWriteFile();
	~Director();
private:
	vector<Skill*> skill_;
};


/************************************/
/********* CLASS SECRETARY **********/
/************************************/
class Secretary : public Person{
public:
	Secretary( string name, string firstName, int hoursToWork, int boxNumber, int number, int postalCode, string street, string town );
	void display();
	string stringForWriteFile();
	~Secretary();
private:
	int hoursToWork_;
};


/************************************/
/*********  CLASS STUDENT ***********/
/************************************/
class Student : virtual public Person{
public:
	Student( string name, string firstName, int percentageOfGlanding , int percentageOfSucces , int boxNumber, int number, int postalCode, string street, string town );
	void addCourseToFollow( string entiteld , int hoursRequire );
	virtual void display();
	virtual string stringForWriteFile();
	~Student();
protected:
	int percentageOfGlanding_;
	int percentageOfSucces_;
	vector<Course*> courseToFollow_;
};



/************************************/
/*********  CLASS TEACHER ***********/
/************************************/
class Teacher : virtual public Person {
public:
	Teacher( string name, string firstName, int hoursTodo , int seniority , int boxNumber, int number, int postalCode, string street, string town ); 
	virtual void display();
	virtual string stringForWriteFile();
	void addCourseToGive( string entiteld , int hoursRequire );
	void addSkill( string entiteld , int salaryBonus );
	~Teacher();
protected:
	vector<Course*> courseToGive_;
	vector<Skill*> skill_;
	int hoursToDo_;
	int seniority_;
};


/************************************/
/*********  CLASS HYBRID  ***********/
/************************************/
class Hybrid : public Teacher, public Student{
public:
	Hybrid( string name, string firstName, int hoursTodo , int seniority , int boxNumber, int number, int postalCode, string street, string town , int percentageOfGlanding , int percentageOfSucces );
	void display();
	string stringForWriteFile();
	~Hybrid();
};



/************************************/
/*********  CLASS DISPLAY ***********/
/************************************/
class Display{
public:
	Display();
	static void centerOutputString( string str );
	static void error();
	static void fillFullLine( const char c);
	static void instruction( string str);
	static void menuGroup();
	static void menuStart();
	static int menuDirector();
	static int menuSecretary();
	static void pauseAtBottom(int cpt);
	static void statsComputerScientist();
	~Display();
};



/************************************/
/********  CLASS TREATMENT *********/
/************************************/
class Treatment{
public:
	Treatment();
	static bool checkCinIntValidity(int min, int max, int valueToVerify);
	static void cutStream ( string str , vector<string>& vectorString , char delimiter);
	static void cutStream ( string str, string& strReturn, int &number );
	static string deleteWhiteSpace( string str, int start, int end);
	static void emptyBuffer();
	static void makeMenu(vector<string> vect);
	static string getAlphaNumeric( string str ); 
	~Treatment();
};