#include <string>
#include <iostream>
#include <iomanip>
#include <sstream>
#include <fstream>
#include <vector>
#include <Windows.h>
#include <algorithm>

using namespace std;

class School;

/************************************/
/********** CLASS ADDRESS ***********/
/************************************/
class Address {
public:
	Address( int boxnumber, int number, int postalCode, string street, string town );
	string display();
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
/**********   CLASS ROOM  ***********/
/************************************/
class Room{
public:
	Room( int area , int numberPlace );
	~Room();
private:
	int area_;
	int numberPlace_;
	static int numberInstance_;
};


/************************************/
/********* CLASS BUILDING ***********/
/************************************/
class Building{
public:
	Building( int numberFloor, Address& address);
	void addRoom();
	void delRoom();
	~Building();
private:
	Address address_;
	int numberFloor_;
	static int numberInstance_;
	vector<Room> room_;
};


/************************************/
/*********  CLASS COURSE  ***********/
/************************************/
class Course{
public:
	Course();
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
	string getFullName();
	string getStatus();
	virtual string stringForWriteFile()=0;
	virtual ~Person();
protected:
	Address address_;
	string name_ , firstName_ , status_;
	vector<Course> course_;
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
	void addBuilding();
	void addDirector();
	void addRoom();
	void addRoomToTeacher();
	void addStudent();
	void delBuilding();
	void delDirector();
	void delListStdudentToCourse();
	void delRoom();
	void delRoomToTeacher();
	void delStudent();
	void displayBuilding();
	void displayCourses();
	void displayDirector();
	static void displayNumberInstance();
	void displayPerson();
	void displayRoom();
	void displayStatistics();
	void displayTotalPersonPerType();
	void hire(Teacher* t);
	void hire(Secretary* s);
	
	string getNameAndStatus();
	Person* getYourDirector();
	string stringForWriteFile();
	~School();

private:
	string type_, name_;
	static int numberInstance_;
	vector<Building*> building_;
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
	static int numberInstance_;
	string function_ , telephone_ , fax_ ;
};



/************************************/
/*********  CLASS GROUP   ***********/
/************************************/
class Group{
public:
	Group(string name, string telephone, string fax, string mail, string website, Address& address );
	void addAdvisor( string name , string firstName , int boxNumber , int number , int postalCode , string street , string town , string status , string telephone , string fax );
	void addSchool( School sch );
	void delAdvisor( int numberOfLine );
	void delSchool( int numberOfLine );
	int displayAdvisorForDelete();
	School displaySchoolForSelect();
	int displaySchoolForDelete();
	void displayInfo();
	void displaySchool();
	~Group();
private:
	string name_ , telephone_ , fax_, mail_, website_;
	Address address_;
	vector<School> school_;
	// pointer for polymorphism
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
	void display();
	string stringForWriteFile();
	~Director();
private:
	static int numberInstance_;
	vector<Skill*> skill_;
};


/************************************/
/********* CLASS SECRETARY **********/
/************************************/
class Secretary : public Person{
public:
	Secretary( string name, string firstName, int hourToDo, int boxNumber, int number, int postalCode, string street, string town );
	void display();
	string stringForWriteFile();
	~Secretary();
private:
	int hoursToDo_;
	static int numberInstance_;
};


/************************************/
/*********  CLASS STUDENT ***********/
/************************************/
class Student : public Person{
public:
	Student();
	void display();
	string stringForWriteFile();
	~Student();
private:
	static int numberInstance_;
protected:
	int percentageOfGlanding_;
	int percentageOfSucces_;	
};



/************************************/
/*********  CLASS TEACHER ***********/
/************************************/
class Teacher : public Person {
public:
	Teacher( string name, string firstName, int hoursTodo , int seniority , int boxNumber, int number, int postalCode, string street, string town );
	void display();
	string stringForWriteFile();
	~Teacher();
private:
	static int numberInstance_;
	vector<Course*> course_;
	vector<Room*> room_;
	vector<Skill*> skill_;
	int hoursToDo_;
	int seniority_;
};


/************************************/
/*********  CLASS HYBRID  ***********/
/************************************/
class Hybrid{
public:
	Hybrid();
	void display();
	~Hybrid();
private:
	static int numberInstance_;
};



/************************************/
/*********  CLASS DISPLAY ***********/
/************************************/
class Display{
public:
	Display();
	static void centerOutputString( string str );
	static void instruction( string str);
	static void error();
	static void fillFullLine( const char c);
	static void menuStart();
	static void menuGroup();
	static int menuDirector();
	static int menuSecretary();
	static int menuComputerScientist();
	static void pauseAtBottom(int cpt);
	~Display();
};



/************************************/
/********  CLASS TREATEMENT *********/
/************************************/
class Treatment{
public:
	Treatment();
	static bool checkCinIntValidity(int min, int max, int valueToVerify);
	static string deleteWhiteSpace( string str, int start, int end);
	static void emptyBuffer();
	static void makeMenu(vector<string> vect);
	static void writeToFile( string str );
	~Treatment();
};