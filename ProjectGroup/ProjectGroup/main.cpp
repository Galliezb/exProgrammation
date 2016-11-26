#include "lesclasses.h"

void main(){
	// variable
	int firstChoice = -1 ; // range : 1-3 ; -1 = no checkValidity

	/*********************************** START MENU *************************************/
	do {

		// display start progam
		Display display = Display();
		display.displayStart();

		// register firstChoice
		cin >> firstChoice;
		// check validity and clean buffer
		display.checkCinIntValidity(1,3,firstChoice);
		
	} while( firstChoice!=0 );


	system("pause");
	system("cls");
}