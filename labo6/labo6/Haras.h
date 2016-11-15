#pragma once
#include<iostream>
#include <string>
#include <vector>

using namespace std;

//class Address;
//class Buyer;
//class Horse;
//class Mare;
//class Stallion;
//class Haras;

class Address {
public:
	Address(int number=1, string street="test", string postalCode="test", string town="test");
	~Address();
private:
	int number_;
	string street_;
	string postalCode_;
	string town_;
};

class Haras {
public:
	//Haras( string name, string telefoon, string website, int number, string street, string postalCode, string town );
	Haras ( string name, string telefoon, string website, Address a );
	void buyHorse(const Buyer &b, const Horse &h);
	// rend la classe abstraite et oblige la réécriture de display dans les dérivkés
	virtual void display()=0;
	~Haras();
private:
	string name_;
	string telefoon_;
	string website_;
	Address address_;
	vector<Horse> horse_;
	vector<Buyer> buyer_;
	static int objectCreated_;
};


//class Address {
//public:
//	Address(int number=1, string street="test", string postalCode="test", string town="test");
//	~Address();
//private:
//	int number_;
//	string street_;
//	string postalCode_;
//	string town_;
//};

class Buyer {
public:
	Buyer();
	~Buyer();
private:
	string name_;
	string telefoon_;
};


class Horse{
public:
	Horse();
	void changePrice();
	void display();
	~Horse();
private:
	Buyer buyer_;
	string temper_;
	string dress_;
	int price_;
};

class Stallion {
public:
	Stallion();
	~Stallion();
private:
	int age_;
};

class Mare {
public:
	Mare();
	~Mare();
private:
	string stateMaternity_;
};