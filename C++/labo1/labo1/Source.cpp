#include <string>
#include <iostream>
#include <stdlib.h>

using namespace std;

int maximum(int a,int b, int c, int d=INT_MIN);
char maximum(char a,char b, char c, char d=32);
string maximum(string a,string b, string c, string d="");
int choix = 0;
bool stop = true;


void menu(){
	std::cout << "Faites votre choix :" << endl;
	std::cout << "1 : Maximum des entiers" << endl;
	std::cout << "2 : Maximum des charactère" << endl;
	std::cout << "3 : Maximum des chaine de caractères" << endl;
	std::cout << "0 : Sortir" << endl;
	cin >> choix;
}

// int min fournira la valeur minimum d'un int selon la configuration
int maximum(int a,int b, int c, int d){

	int max = a;
	if ( b > max ) max = a;
	if ( c > max ) max = c;
	if ( d!=INT_MIN && d > max ) max = d;

	return max;

};
// 32 valeur mini sur la table ascii ( espace )
char maximum(char a,char b, char c, char d){

	int max = a;
	if ( b > max ) max = a;
	if ( c > max ) max = c;
	if ( d!=32 && d > max ) max = d;

	return max;

};

string maximum(string a,string b, string c, string d){

	int max = 0;
	if ( b.length() > max ) max = 1;
	if ( c.length() > max ) max = 2;
	if ( d!="" && d.length() > max ) max = 3;

	switch(max){
	
		case 0:
			return a;
			break;
		case 1:
			return b;
			break;
		case 2:
			return c;
			break;
		default:
			return d;
			break;
	
	}

}

int main (int argc, char * argv[]){

	string stringSource1 = argv[2];
	string stringSource2 = argv[3];
	string stringSource3 = argv[4];

	if ( argc < 5 ){
		std::cout << "Parametres incorrect " << argc << " fourni(s) / 5 requis" << endl;
		stop=true;
		
	} else {
	
		// arguments INT
		if ( typeid(stringSource1) == typeid(int) && typeid(stringSource2) == typeid(int) && typeid(stringSource3) == typeid(int) ) {
			int a = stoi(stringSource1);
			int b = stoi(stringSource2);
			int c = stoi(stringSource3);
			std::cout << "le chiffre max est : " << maximum(a,b,c) << endl;
		//argument CHAR
		} else if ( stringSource1.length() == 1 && stringSource2.length() == 1 && stringSource3.length() == 1 ) {
			char a = stringSource1[1];
			char b = stringSource2[1];
			char c = stringSource3[1];
			maximum(a,b,c);
			std::cout << "le caractere max est : " << maximum(a,b,c) << endl;
		// argument string
		} else {
		
			
			std::cout << "la plus grand chaine est : " << maximum(stringSource1,stringSource2,stringSource3) << endl;
		}
		system("pause");
		system("cls");
		while(stop){
			
			menu();
			
			if(choix==0){
				system("cls");
				stop = false;
				std::cout << "Bye" << endl;
				system("pause");
			} else if ( choix == 1 ){
				string a,b,c,d;
				system("cls");
				std::cout << "Veuillez entrer le premier entier : ";
				cin >> a;
				std::cout << "Veuillez entrer le deuxieme entier : ";
				cin >> b;
				std::cout << "Veuillez entrer le troisieme entier : ";
				cin >> c;
				std::cout << "Veuillez entrer le quatrieme entier ( Facultatif, tapez Entré pour passer ) : ";
				cin >> c;
				if (typeid(a)!=typeid(int) || typeid(b)!=typeid(int) || typeid(c)!=typeid(int)){
					std::cout << "Ce ne sont pas des entiers. Plein le cul je me casse." << endl << "Bye" << endl;
					return 0;
				}
				if ( typeid(d)!=typeid(int) ){  d=INT_MIN; }

				system("cls");
				std::cout << "le chiffre maximum est : " << maximum(a,b,c,d) << endl;

			} else if ( choix == 2 ){

				char a,b,c,d;
				system("cls");
				std::cout << "Veuillez entrer le premier caractere : ";
				cin >> a;
				std::cout << "Veuillez entrer le deuxieme caractere : ";
				cin >> b;
				std::cout << "Veuillez entrer le troisieme caractere : ";
				cin >> c;
				std::cout << "Veuillez entrer le quatrieme caractere ( Facultatif, tapez Entré pour passer ) : ";
				cin >> c;
				if (typeid(a)!=typeid(char) || typeid(b)!=typeid(char) || typeid(c)!=typeid(char)){
					std::cout << "Ce ne sont pas des caracteres. Plein le cul je me casse." << endl << "Bye" << endl;
					return 0;
				}
				if ( typeid(d)!=typeid(char) ){  d=32; }

				system("cls");
				std::cout << "le caractere maximum est : " << maximum(a,b,c,d) << endl;

			} else if ( choix == 3 ){
			
				string a,b,c,d;
				system("cls");
				std::cout << "Veuillez entrer la premiere chaine caracteres : ";
				cin >> a;
				std::cout << "Veuillez entrer la deuxieme chaine caracteres : ";
				cin >> b;
				std::cout << "Veuillez entrer la troisieme chaine caracteres : ";
				cin >> c;
				std::cout << "Veuillez entrer la quatrieme chaines caracteres ( Facultatif, tapez Entré pour passer ) : ";
				cin >> c;
				if (typeid(a)!=typeid(string) || typeid(b)!=typeid(string) || typeid(c)!=typeid(string)){
					std::cout << "Ce ne sont pas des chaines de caracteres. Plein le cul je me casse." << endl << "Bye" << endl;
					
					return 0;
				}
				if ( typeid(d)!=typeid(string) ){ d=""; }

				system("cls");
				std::cout << "la plus grande chainde caractere maximum est : " << maximum(a,b,c,d) << endl;

			}

		}
	
	}
	
}