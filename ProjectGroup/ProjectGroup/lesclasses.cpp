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
