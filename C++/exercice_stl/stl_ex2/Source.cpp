#include <stdio.h>
#include <iostream>
#include <list>

using namespace std;

void main(){

	//Cr�er 2 listes comprenant 10 minuscules choisies de fa�on al�atoire,
	list<char> l1 = { 'a','d','c','g','f','z','y','k','m','o'};
	list<char> l2 = {'g','s','a','g','d','z','j','z','h','p'};

	// trier les listes
	l1.sort();

	// �changer leur conten
	l1.swap(l2);


	//  afficher les.
	int i = 0;
	for ( char n : l1 ){
		cout << "[" << i << "] : " << n  << endl;
		i++;	
	}

	system("pause");
	system("cls");

}