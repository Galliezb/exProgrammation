#include <iostream>
#include "main.h"
using namespace std;
int saisirParam(){

	int rayon;

	cout << "Veuillez introduire un float comme rayon :"<< endl;
	cin >> rayon;

	return rayon;

}

void saisirParam(int *largeur, int *longueur){
	int la,lo;
	cout << "Veuillez introduire la largeur ( int )" << endl;
	cin >> la;
	cout << "veuillez introduire la longueur ( int ) " << endl;
	cin >> lo;

	*largeur = la;
	*longueur = lo;
}

void main(){

}