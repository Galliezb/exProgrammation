#include "lesclasses.h"

Fraction::Fraction(){
	cout << "Constructeur de Fraction" << endl;
}

Fraction::~Fraction(){
	cout << "Deconstructeur de Fration" << endl;
}

bool operator>(Fraction & a , Fraction& b ){

	if ( a.numerateur_ / a.denominateur_ > b.numerateur_ / b.denominateur_ ){
		return true;
	} else {
		return false;
	}
}

iostream operator<<(iostream  ios, Fraction & fraction){
	
	ios << endl << "Num : " << fraction.numerateur_ << endl << "Den : " << fraction.denominateur_ << endl; 

	return ios;
}
