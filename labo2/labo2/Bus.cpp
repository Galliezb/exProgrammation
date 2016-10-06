#include <iostream>

#include "Bus.h"

using std::cout;
using std::endl;

Bus::Bus(){

	registrationNumber_ = 0;
	startupYear_ = 1970;
	totalWeight_ = 0;

}



void Bus::displayData(){

	cout << "Registration Number : " << registrationNumber_ << endl;
	cout << "Startup Year : " << startupYear_ << endl;
	cout << "Total Weight : " << totalWeight_ << endl;

}



int Bus::upWeight ( unsigned int weight){

	if ( weight > 0 ){
		totalWeight_ += weight;
	} else {
		cout << "weight unsigned int only !" << endl;
	}

	return totalWeight_;

}



bool Bus::compareBus ( const Bus& busToCompare ){

	return ( registrationNumber_ == busToCompare.registrationNumber_ 
	     && startupYear_ == busToCompare.startupYear_
		 && totalWeight_ == busToCompare.totalWeight_ );

}



Bus Bus::beHeaviest( const Bus& busToCompare ){


	// and if the 2 are equal ?
	if ( totalWeight_ > busToCompare.totalWeight_ ){
	
		return *this;
	
	} else {
	
		return busToCompare;
	
	}


}



void Bus::displayAllUser(){

	for (int i = 0;	i < user_.size(); i++){

		user_[i].displayData();

	}

}



void Bus::addUser(){

	User user1;
	user_.push_back( user1 );

}



Bus::~Bus(){
}
