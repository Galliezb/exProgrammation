#pragma once
#include <stdio.h>
#include <iostream>
#include <sstream>

template < class T > class Vecteur{
public : 
	Vecteur( int max );
	void affiche();
	~Vecteur();
private:
	T* tab;	
};

template<class T> Vecteur<T>::Vecteur(int max){

	tab = new T tab[max];

}

template<class T> void Vecteur<int>::affiche(){

	cout << "Type : Int" << endl;
	cout << " Valeurs : ";
	for (int i = 0; i<max_; i++){
		cout << tab[i] << " - ";
	}
	cout << "**********************" << endl;

}

template<class T> inline Vecteur<T>::~Vecteur(){
	delete tab;
}
