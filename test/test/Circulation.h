#pragma once

#include <string>
#include <iostream>
#include <vector>


using std::cout;
using std::endl;
using std::string;
using std::vector;


class Date;
class Circulation;
class Tank;


class Date{

public:
	Date(int day=0, int month=0, int year=0);
	void afficher();
	void setDate(int year, int month, int day);
	~Date();
private:
	int day_;
	int month_;
	int year_;

};


class Tank{

public:
	Tank(int capacity=0);
	void afficher();
	~Tank();
private:
	int capacity_;
};



class Vehicle{

public:
	Vehicle( int numberWheel, int maxSpeed );
	virtual void afficher();
	virtual ~Vehicle()=0;
protected:
	int numberWheel_;
	int maxSpeed_;
};


class Bike : public Vehicle{

public:
	Bike(string type, int numberWheel, int maxSpeed );
	void afficher();
	static bool compare(Bike b, Bike a);
	~Bike();
private:
	string type_;
};


class Car : public Vehicle{

public:
	Car( string mark, Tank tank, int numberWheel, int maxSpeed );
	void afficher();
	~Car();
private:
	string mark_;
	Tank tank_;
};

class Truck : public Vehicle{

public:
	Truck( int weight, int numberWheel, int maxSpeed  );
	void afficher();
	~Truck();
	static int numberObjectCreated;
private:
	int weight_;
};

class Circulation {

public:
	Circulation( string town, int year, int month, int day );
	void afficher();
	void addVehicle(Bike bike);
	void addVehicle(Car car);
	void addVehicle(Truck trucks);
	void displayVehicle();
	~Circulation();

private:
	string town_;
	Date date_;
	vector <Bike> bike_;
	vector <Car> car_;
	vector <Truck> truck_;
};



