#pragma once

#include <iostream>
#include <string>

using namespace std;

template <class T> T fct (T a, T b){
	if ( a > b ){
		return a;
		cout << "instance A > instance B" << endl;
	} else {
		cout << "instance A < instance B" << endl;
	}
}

class Fraction{
private:
	int numerateur_;
	int denominateur_;
public:
	Fraction();
	friend bool operator>( Fraction& a , Fraction& b );
	friend iostream operator<<( iostream& ios , Fraction& fraction );
	~Fraction();
};



