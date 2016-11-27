#include "lesclasses.h"

void main(){
	// variable
	int choiceMenuStart = -1 ; // range : 1-3 ; -1 = no checkValidity
	Address& addressHelha = Address(NULL,159,7000,"Chaussée de Binche","Mons");
	Group helha = Group("HELHA","+ 32 (0)65 40 41 41","+ 32 (0)65 34 04 52","info@helha.be","www.helha.be",addressHelha);
	system("pause");
	/*********************************** START MENU *************************************/
	do {

		// display start progam
		Display display = Display();
		display.menuStart();

		// register choiceMenuStart
		cin >> choiceMenuStart;
		// check validity and clean buffer
		display.checkCinIntValidity(0,3,choiceMenuStart);

		/*********************************** START MENU GROUP *************************************/
		if ( choiceMenuStart == 1 ){
		
			int choiceMenuGroup = -1;

			do {
			
				display.menuGroup();

				// register choiceMenuGroup
				cin >> choiceMenuGroup;
				// check validity and clean buffer
				display.checkCinIntValidity(0,1,choiceMenuGroup);

				/*********************************** DISPLAY INFO GROUP *************************************/
				if ( choiceMenuGroup == 1 ){
				
					helha.displayInfo();

				/*********************************** ADD SCHOOL *************************************/
				} else if ( choiceMenuGroup == 2 ) {
					
				}
				
			
			} while( choiceMenuGroup!=0 );

		}
		
	} while( choiceMenuStart!=0 );

	//system("pause");
	//system("cls");
}