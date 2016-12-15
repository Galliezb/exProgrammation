#include <typeinfo>
#include <iostream>

using namespace std;

void main(){

	double test = 1.20326;

	cout << " 0 " << typeid( sqrt(5) ).name() << endl;
	cout << " 1 " << typeid( sqrt(4.3) ).name() << endl;
	cout << " 2 " << typeid( sqrt(exp2(test)) ).name() << endl;

	system("pause");

}