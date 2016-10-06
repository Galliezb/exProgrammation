#pragma once
#include <iostream>

#include "Bus.h"

using std::cout;
using std::string;
using std::endl;

void main(){

	Bus bus[3] = {Bus()};

	// Add user
	for ( int i = 0; i<3; i++ ){ bus[0].addUser(); }
	for ( int i = 0; i<5; i++ ){ bus[1].addUser(); }
	for ( int i = 0; i<7; i++ ){ bus[2].addUser(); }

	// beHeaviest
	
	cout << "Bus 1, new weight : " << bus[0].upWeight() << endl;
	cout << "Bus 1, new weight : " << bus[0].upWeight(500) << endl;
	
	system("pause");
	system("cls");


	// compare
	string identical="";
	( bus[0].compareBus(bus[1]) ) ? identical = "identical" : identical = "not identical";
	cout << "Bus 1 and Bus 2 are " << identical << endl;


	( bus[1].compareBus(bus[2]) ) ? identical = "identical" : identical = "not identical";
	cout << "Bus 2 and Bus 3 are " << identical << endl;


	( bus[0].compareBus(bus[2]) ) ? identical = "identical" : identical = "not identical";
	cout << "Bus 1 and Bus 3 are " << identical << endl;

	system("pause");
	system("cls");



	// beHeaviest
	Bus& heaviestBus = bus[0].beHeaviest(bus[1]);
	cout << "Heaviest Bus : " << endl;
	heaviestBus.displayData();

	system("pause");
	system("cls");


	// display all user
	for ( int i = 0; i<3; i++ ){ bus[i].displayAllUser(); }
	system("pause");

	system("pause");
	system("cls");


	cout << "end software" << endl;
	system("pause");
	system("cls");


}