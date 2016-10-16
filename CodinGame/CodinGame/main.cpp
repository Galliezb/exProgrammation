#include <iostream>
#include <string>
#include <cmath>
#include <stdlib.h>
#include <vector>

using namespace std;

int main()
{
	int n=5; // the number of temperatures to analyse
			 //cin >> n; cin.ignore();
	string temps = "-1 -1 -8 4 5"; // the n temperatures expressed as integers ranging from -273 to 5526
								  //getline(cin, temps);

	

	// go found < value
	short int sortie = 5526;

	for ( unsigned short int i = 0; i < n; i++ ){

		// stoi take first number detected and stop at space
		string::size_type sString;
		short int temp = stoi(temps, &sString);

		if ( fabs( temp ) < fabs( sortie )  ){

			sortie = temp;

		}  else if ( fabs( temp ) == fabs ( sortie ) && temp != sortie ){

			// if 2 value are equal => |value|
			sortie = fabs ( temp );

		}
		// delete number detected from the string
		temps = temps.substr(sString);

	}

	cout << sortie << endl;

	system("pause");
}