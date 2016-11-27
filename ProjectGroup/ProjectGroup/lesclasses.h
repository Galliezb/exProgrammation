#pragma once
#include <string>
#include <iostream>
#include <iomanip>
#include <fstream>
#include <vector>
#include <Windows.h>

using namespace std;

/************************************/
/********** CLASS ADDRESS ***********/
/************************************/
class Address {
public:
	Address( int boxnumber, int number, int postalCode, string street, string town );
	string display();
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
	Person( string name , string firstName , int boxNumber , int number , int postalCode , string street , string town );
	virtual void display()=0;
	~Person();
protected:
	Address address_;
	string name_ , firstName_;
private:
	static int numberInstance_;
};




/************************************/
/*********  CLASS SCHOOL  ***********/
/************************************/
class School{
public:
	School( string type , string name );
	void addBuilding();
	void addDirector();
	void addRoom();
	void addStudent();
	void delBuilding();
	void delDirector();
	void delRoom();
	void delStudent();
	void displayBuilding();
	void displayCourses();
	void displayDirector();
	static void displayNumberInstance();
	void displayPerson();
	void displayRoom();
	void displayStatistics();
	void displayTotalPersonPerType();
	~School();
private:
	string type_, name_;
	static int numberInstance_;
	vector<Building> building_;
	vector<Person> person_;
};



/************************************/
/********* CLASS ADVISOR ***********/
/************************************/
class Advisor : public Person {
public:
	Advisor( string name , string firstName , int boxNumber , int number , int postalCode , string street , string town , string statut , string telefoon , string fax );
	void display();
	~Advisor();
public:
	static int numberInstance_;
	string statut_ , telefoon_ , fax_ ;
};



/************************************/
/*********  CLASS GROUP   ***********/
/************************************/
class Group{
public:
	Group(string name, string telefoon, string fax, string mail, string website, Address& address );
	void addSchool();
	void delSchool();
	void displayInfo();
	void displaySchool();
	~Group();
private:
	string name_ , telefoon_ , fax_, mail_, website_;
	Address address_;
	vector<School> school_;
	// pointer for polymorphism
	vector<Person*> advisor_;
	static int numberInstance_;
};



/************************************/
/*********   CLASS SKILL  ***********/
/************************************/
class Skill{
public:
	Skill();
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
	Director();
	void display();
	void hire();
	void fire();
	~Director();
private:
	static int numberInstance_;
	vector<Skill> skill_;
};


/************************************/
/********* CLASS SECRETARY **********/
/************************************/
class Secretary : public Person{
public:
	Secretary();
	void addRoomToTeacher();
	void addStudentToCourse();
	void delRoomToTeacher();
	void delStdudentToCourse();
	void display();
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
	~Student();
private:
	static int numberInstance_;
protected:
	int hoursToDo_;
	int percentageOfGlanding_;
	int percentageOfSucces_;	
};



/************************************/
/*********  CLASS TEACHER ***********/
/************************************/
class Teacher : public Person {
public:
	Teacher();
	void display();
	~Teacher();
private:
	static int numberInstance_;
	vector<Course> course_;
	vector<Room> room_;
	vector<Skill> skill_;
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
/******* CLASS ENUM ERROR  **********/
/************************************/
enum class Error {
	number = 0
};



/************************************/
/*********  CLASS DISPLAY ***********/
/************************************/
class Display{
public:
	Display();
	static void checkCinIntValidity(int min, int max, int valueToVerify);
	static void centerOutputString( string str );
	static void emptyBuffer();
	static void error( Error error );
	static void fillFullLine( const char c);
	static void menuStart();
	static void menuGroup();
	static void pauseAtBottom(int cpt);
	~Display();
};
