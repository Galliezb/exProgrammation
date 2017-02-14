#include <iostream>

#include "User.h"

using std::cout;
using std::string;
using std::endl;

User::User(){

	name_ = "Jean";
	subscriber_ = false;

}



void User::displayData(){

	string subscriber;
	if ( subscriber_ ){
		subscriber="Subscriber";
	} else {
		subscriber="Non-Subscriber";	
	}

	cout << "Name  : " << name_ << " ( " << subscriber << " ) " << endl;

}



User::~User(){
}
