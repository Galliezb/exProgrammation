#include <iostream>

#include "User.h"


User::User(){

	name_ = "Jean";
	subscriber_ = false;

}



void User::displayData(){

	string subscriber;
	(subscriber_)?subscriber="Subscriber":subscriber="Non-Subscriber";

	cout << "Name  : " << name_ << " ( " << subscriber << " ) " << endl;

}



User::~User(){
}
