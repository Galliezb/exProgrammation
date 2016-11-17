#include <iostream>
#include <fstream>
#include <iomanip>

using namespace std;

void main(){

	// ouverture du fichier
	fstream fileInOut;
	// Ouvre le fichier et le vide
	fileInOut.open("./test.txt",ios::trunc|ios::out);

	if ( fileInOut.fail() ){
		cout << "ERROR : file not open !" << endl;
	} else {
		cout << "SUCCES : file open. Ready to work guys !" << endl;
	}

	for (int i = 10; i<101; i+=10){

		istream entre;
		entre.
	}


	system("pause");
}