#include "lesclasses.h"

void main(){

	// variable
	int choiceMenuStart = -1 ; // range : 1-3 ; -1 = no checkValidity
	bool goodOrRetry = false;  // false for bad answer

	Address& addressHelha = Address(NULL,159,7000,"Chaussée de Binche","Mons");
	Group helha = Group("HELHA","+ 32 (0)65 40 41 41","+ 32 (0)65 34 04 52","info@helha.be","www.helha.be",addressHelha);


	
	/*********************************** START MENU *************************************/
	do {

		// display start progam
		Display display = Display();
		display.menuStart();

		// register choiceMenuStart
		cin >> choiceMenuStart;
		
		// check validity and clean buffer
		if ( !display.checkCinIntValidity(0,3,choiceMenuStart) ){
			// default for restart START MENU
			choiceMenuStart = -1;
		}

		/*********************************** START MENU GROUP *************************************/
		if ( choiceMenuStart == 1 ){
		
			int choiceMenuGroup = -1;

			do {
			
				display.menuGroup();

				// register choiceMenuGroup
				cin >> choiceMenuGroup;
				// check validity and clean buffer
				if ( !display.checkCinIntValidity(0,3,choiceMenuGroup) ){
					
					// default for restart START MENU GROUP
					choiceMenuGroup = -1;

				}

				/*********************************** DISPLAY INFO GROUP *************************************/
				if ( choiceMenuGroup == 1 ){
				
					helha.displayInfo();

				/*********************************** ADD ADVISOR *************************************/
				} else if ( choiceMenuGroup == 2 ) {
					
					string name , firstName , street , town , status , telefoon , fax;
					int boxNumber , number , postalCode;

					Display::fillFullLine('-');
					Display::centerOutputString( string ("ENTREZ LE NOM") );
					Display::fillFullLine('-');
					Display::pauseAtBottom(31);
					cin >> name;

					Display::fillFullLine('-');
					Display::centerOutputString( string ("ENTREZ LE PRENOM") );
					Display::fillFullLine('-');
					Display::pauseAtBottom(31);
					cin >> firstName;

					Display::fillFullLine('-');
					Display::centerOutputString( string ("ENTREZ LE STATUS") );
					Display::fillFullLine('-');
					Display::pauseAtBottom(31);
					cin >> status;

					Display::fillFullLine('-');
					Display::centerOutputString( string ("ENTREZ LA RUE") );
					Display::fillFullLine('-');
					Display::pauseAtBottom(31);
					cin >> street;

					do {
						Display::fillFullLine('-');
						Display::centerOutputString( string ("ENTREZ LA BOITE POSTALE ( 0 si aucune )") );
						Display::fillFullLine('-');
						Display::pauseAtBottom(31);
						cin >> boxNumber;
						goodOrRetry = Display::checkCinIntValidity(0,9999,boxNumber);
					} while ( !goodOrRetry );

					do {
						Display::fillFullLine('-');
						Display::centerOutputString( string ("ENTREZ LE NUMERO") );
						Display::fillFullLine('-');
						Display::pauseAtBottom(31);
						cin >> number;
						goodOrRetry = Display::checkCinIntValidity(0,9999,number);
					} while ( !goodOrRetry );

					Display::fillFullLine('-');
					Display::centerOutputString( string ("ENTREZ LA VILLE") );
					Display::fillFullLine('-');
					Display::pauseAtBottom(31);
					cin >> town;

					do {
						Display::fillFullLine('-');
						Display::centerOutputString( string ("ENTREZ LE CODE POSTAL") );
						Display::fillFullLine('-');
						Display::pauseAtBottom(31);
						cin >> postalCode;
						goodOrRetry = Display::checkCinIntValidity(0,9999,postalCode);
					} while ( !goodOrRetry );

					Display::fillFullLine('-');
					Display::centerOutputString( string ("ENTREZ LE NUMERO DE TELEPHONE") );
					Display::fillFullLine('-');
					Display::pauseAtBottom(31);
					cin >> telefoon;

					Display::fillFullLine('-');
					Display::centerOutputString( string ("ENTREZ LE NUMERO DE FAX") );
					Display::fillFullLine('-');
					Display::pauseAtBottom(31);
					cin >> fax;

					helha.addAdvisor(name,firstName,boxNumber,number,postalCode,street,town,status,telefoon,fax);

					system("cls");
					Display::centerOutputString("NOUVEAU CONSEILLER ENREGISTRE");


				/*********************************** DEL ADVISOR *************************************/
				} else if ( choiceMenuGroup == 3 ) {

					int numberOfAdvisorToDelete=-1;
					goodOrRetry = false;

					do {

						// Display list of Advisor for the choice
						numberOfAdvisorToDelete = helha.displayAdvisorForDelete();

					} while ( numberOfAdvisorToDelete == -1 );

					// del Advisor and regenerate file
					helha.delAdvisor(numberOfAdvisorToDelete);


				}

			
			} while( choiceMenuGroup!=0 );

		}
		
	} while( choiceMenuStart!=0 );

	//system("pause");
	//system("cls");
}