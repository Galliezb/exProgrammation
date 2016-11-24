#pragma once
#include <string>
#include <iostream>
#include <vector>

using namespace std;

/************************************/
/********** CLASS ADDRESS ***********/
/************************************/
class Address {
public:
	Address();
	void display();
	~Address();
private:
	int boxnumber_;
	static int numberInstance_;
	int number_;
	int postalCode;
	string stree_;
	string town_;
};

/************************************/
/**********   CLASS ROOM  ***********/
/************************************/
class Room{
public:
	Room();
	~Room();
private:
	int area_;
	static int numberInstance_;
	int numberPlace;
};


/************************************/
/********* CLASS BUILDING ***********/
/************************************/
class Building{
public:
	Building();
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
/*********  CLASS SCHOOL  ***********/
/************************************/
class School{
public:
	School();
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
	string level_;
	static int numberInstance_;
	vector<Building> building_;
	vector<Person> person_;
};



/************************************/
/*********  CLASS GROUP   ***********/
/************************************/
class Group{
public:
	Group();
	void addSchool();
	void delSchool();
	void displaySchool();
	~Group();
private:
	string name_;
	Address address_;
	vector<School> school_;
	vector<Advisor> advisor_;
};

/**********************************************************************************************/
// TODO :
// Teacher
// Student
// Secretary
// Director
// Advisor
/**********************************************************************************************/

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
/*********  CLASS PERSON  ***********/
/************************************/
class Person{
public:
	Person();
	virtual void display()=0;
	virtual ~Person()=0;
protected:
	Address address_;
	Barcode barcode_;
	string firstname_;
	string name_;
};



/************************************/
/********* CLASS BARCODE  ***********/
/************************************/
class Barcode {
public:
	Barcode();
	bool checkSingle();
	~Barcode();
private:
	static vector<int> barcode_;
	static int numberInstance_;

};