#include "Circulation.h"

int Truck::numberObjectCreated = 0;

Circulation::Circulation( string town, int year, int month, int day ){

	town_ = town;
	date_.setDate( year, month, day );

}



void Circulation::afficher(){

	cout << "Circulation town : " << town_ << endl << "Circulation date : ";
	date_.afficher();

}



void Circulation::addVehicle(Bike bike){

	bike_.push_back(bike);

}



void Circulation::addVehicle(Car car){

	car_.push_back(car);

}



void Circulation::addVehicle(Truck truck){

	truck_.push_back(truck);

}



void Circulation::displayVehicle(){

	cout << "*********************** BIKE ******************************" << endl;
	for each (Bike b in bike_){
		
		b.afficher();

	}

	cout << "*********************** CAR ******************************" << endl;
	for each (Car c in car_){

		c.afficher();

	}

	cout << "*********************** TRUCK ******************************" << endl;
	for each (Truck t in truck_){

		t.afficher();

	}

}



Circulation::~Circulation(){

	// cout << "Destructive Circulation" << endl;

}



Date::Date(int day, int month, int year){

	day_=day;
	month_=month;
	year_=year;

}



void Date::afficher(){

	cout << "Date : " << year_ << "/" << month_ << "/" << day_ << endl;

}



void Date::setDate(int year, int month, int day){

	year_ = year;
	month_ = month;
	day_ = day;

}



Date::~Date(){

	//cout << "Destructive Date" << endl;

}

Vehicle::Vehicle( int numberWheel, int maxSpeed ){

	numberWheel_ = numberWheel;
	maxSpeed_ = maxSpeed;
}

void Vehicle::afficher(){

	cout << "NumberWHeel : " << numberWheel_ << endl << "Max speed : " << maxSpeed_ << endl;

}

Vehicle::~Vehicle(){

	//cout << "Destructive Vehicle" << endl;

}



Bike::Bike(string type, int numberWheel, int maxSpeed) : Vehicle( numberWheel, maxSpeed ){

	type_ = type;

}



void Bike::afficher(){

	cout << "Type Bike : " << type_ << endl;
	Vehicle::afficher();

}



bool Bike::compare(Bike b, Bike a){

	if ( a.type_ == b.type_ ){
	
		return true;
	
	} else {
	
		return false;

	}

}



Bike::~Bike(){

	//cout << "Destructive Bike" << endl;

}

Car::Car(string mark, Tank tank, int numberWheel, int maxSpeed) : Vehicle( numberWheel,maxSpeed ){

	mark_ = mark;
	tank_ = tank;

}



void Car::afficher(){

	cout << "Mark : " << mark_ << endl;
	tank_.afficher();
	Vehicle::afficher();

}



Car::~Car(){

	//cout << "Destructive Car" << endl;

}



Tank::Tank(int capacity){

	capacity_ = capacity;

}



void Tank::afficher(){

	cout << "Tank capacity : " << capacity_ << endl;

}



Tank::~Tank(){

	//cout << "Destructive Tank" << endl;

}



Truck::Truck(int weight, int numberWheel, int maxSpeed) : Vehicle ( numberWheel, maxSpeed ){

	weight_ = weight;
	Truck::numberObjectCreated++;

}



void Truck::afficher(){

	cout << "Truck weight : " << weight_ << endl;
	Vehicle::afficher();

}



Truck::~Truck(){
	// cout << "Destructive Truck" << endl;
}
