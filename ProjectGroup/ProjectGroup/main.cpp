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
				if ( !display.checkCinIntValidity(0,5,choiceMenuGroup) ){
					
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

					Display::instruction("ENTREZ LE NOM");
					getline( cin , name );


					Display::instruction("ENTREZ LE PRENOM");
					getline( cin , firstName );


					Display::instruction("ENTREZ LE STATUS");
					getline( cin , status );


					Display::instruction("ENTREZ LA RUE");
					getline( cin , street );


					do {
						Display::instruction("ENTREZ LA BOITE POSTALE ( 0 si aucune )");
						cin >> boxNumber;
						goodOrRetry = Display::checkCinIntValidity(0,9999,boxNumber);
					} while ( !goodOrRetry );

					do {
						Display::instruction("ENTREZ LE NUMERO");
						cin >> number;
						goodOrRetry = Display::checkCinIntValidity(0,9999,number);
					} while ( !goodOrRetry );


					Display::instruction("ENTREZ LA VILLE");
					getline( cin , town );

					do {
						Display::instruction("ENTREZ LE CODE POSTAL");
						cin >> postalCode;
						goodOrRetry = Display::checkCinIntValidity(0,9999,postalCode);
					} while ( !goodOrRetry );

					Display::instruction("ENTREZ LE NUMERO DE TELEPHONE");
					getline( cin , telefoon );

					Display::instruction("ENTREZ LE NUMERO DE FAX");
					getline( cin , fax );


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

				/*********************************** ADD SCHOOL *************************************/
				} else if ( choiceMenuGroup == 4 ) {
					
					string name, type;

					Display::instruction("ENTREZ LE NOM DE L ECOLE");
					getline( cin , name );

					Display::instruction("ENTREZ LE TYPE D ECOLE");
					getline( cin , type );

					School sc = School( type, name );
					helha.addSchool( sc );



				/*********************************** DEL SCHOOL *************************************/
				} else if ( choiceMenuGroup == 5 ) {

				}

			
			} while( choiceMenuGroup!=0 );

		}
		
	} while( choiceMenuStart!=0 );

	//system("pause");
	//system("cls");
}