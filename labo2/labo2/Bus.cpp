#include <iostream>

#include "Bus.h"

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



int Bus::upWeight ( int weight){

	totalWeight_ += weight;

	return totalWeight_;

}



bool Bus::compareBus ( const Bus& bus1, const Bus& bus2 ){

	if ( bus1.registrationNumber_ == bus2.registrationNumber_ 
	     && bus1.startupYear_ == bus2.startupYear_
		 && bus1.totalWeight_ == bus2.totalWeight_ ){
	
		return true;
	
	} else {
	
		return false;
	
	}
}



Bus Bus::beHeaviest( const Bus& bus1, const Bus& bus2 ){

	if ( bus1.totalWeight_ > bus2.totalWeight_ ){
	
		return bus1;
	
	} else if ( bus1.totalWeight_ < bus2.totalWeight_ ){
	
		return bus2;
	
	} else {
	
	// ERROR : What do here ?
	return bus1;
	
	}


}



void Bus::displayAllUser(){

	for (int i = 0;	i<user_.size(); i++){

		user_[i].displayData();

	}

}



void Bus::addUser(){

	User user1;
	user_.push_back( user1 );

}



Bus::~Bus(){
}
