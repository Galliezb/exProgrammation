#include "lesclasses.h"

void main(){

	// variable
	int choiceMenuStart = -1 ; // range : 1-3 ; -1 = no checkValidity
	bool goodOrRetry = false;  // false for bad answer


	// Handle de fenêtre ( https://msdn.microsoft.com/fr-fr/library/cc485739(v=vs.71).aspx )
	HWND console = GetConsoleWindow();
	// structure rectangle ( left, top, right, bottom => https://msdn.microsoft.com/en-us/library/a5ch4fda.aspx )
	RECT r;
	// on stock les dimensions de la fenêtre console dans le RECT
	GetWindowRect(console, &r);
	//MoveWindow(handle fenêtre, x, y, largeur, hauteur, bool_redimensionnement);
	MoveWindow(console, r.left, r.top, 1250, 600, TRUE);

	Address& addressHelha = Address(NULL,159,7000,"Chaussée de Binche","Mons");
	Group helha = Group("HELHA","+ 32 (0)65 40 41 41","+ 32 (0)65 34 04 52","info@helha.be","www.helha.be",addressHelha);


	ifstream fi;
	fi.open("test.txt",ios::in);
	string myStr;
	while ( getline(fi,myStr) ){
		cout << "size :" << myStr.size() << endl;
		cout << "size - chaine base :" << myStr.size()-150 << endl;
	}

	
	/*********************************** START MENU *************************************/
	do {

		// display start progam
		Display::menuStart();

		// register choiceMenuStart
		cin >> choiceMenuStart;

		// check validity and clean buffer
		if ( !Treatment::checkCinIntValidity(0,4,choiceMenuStart) ){
			// default for restart START MENU
			choiceMenuStart = -1;
		}

		/*********************************** START MENU GROUP *************************************/
		if ( choiceMenuStart == 1 ){
		
			int choiceMenuGroup = -1;

			do {
			
				Display::menuGroup();

				// register choiceMenuGroup
				cin >> choiceMenuGroup;
				// check validity and clean buffer
				if ( !Treatment::checkCinIntValidity(0,5,choiceMenuGroup) ){
					
					// default for restart START MENU GROUP
					choiceMenuGroup = -1;

				}

				/*********************************** DISPLAY INFO GROUP *************************************/
				if ( choiceMenuGroup == 1 ){
				
					helha.displayInfo();
				
				/*********************************** DISPLAY INFO GROUP *************************************/
				} else if ( choiceMenuGroup == 2 ){

						helha.displaySchool();

				/*********************************** ADD ADVISOR *************************************/
				} else if ( choiceMenuGroup == 3 ) {
					
					string name , firstName , street , town , status , telephone , fax;
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
						goodOrRetry = Treatment::checkCinIntValidity(0,9999,boxNumber);
					} while ( !goodOrRetry );

					do {
						Display::instruction("ENTREZ LE NUMERO");
						cin >> number;
						goodOrRetry = Treatment::checkCinIntValidity(0,9999,number);
					} while ( !goodOrRetry );


					Display::instruction("ENTREZ LA VILLE");
					getline( cin , town );

					do {
						Display::instruction("ENTREZ LE CODE POSTAL");
						cin >> postalCode;
						goodOrRetry = Treatment::checkCinIntValidity(0,9999,postalCode);
					} while ( !goodOrRetry );

					Display::instruction("ENTREZ LE NUMERO DE TELEPHONE");
					getline( cin , telephone );

					Display::instruction("ENTREZ LE NUMERO DE FAX");
					getline( cin , fax );


					helha.addAdvisor(name,firstName,boxNumber,number,postalCode,street,town,status,telephone,fax);

					system("cls");
					Display::centerOutputString("NOUVEAU CONSEILLER ENREGISTRE");


				/*********************************** DEL ADVISOR *************************************/
				} else if ( choiceMenuGroup == 4 ) {

					int numberOfAdvisorToDelete=-1;

					// only number or Retry
					do {

						// Display list of Advisor for the choice
						numberOfAdvisorToDelete = helha.displayAdvisorForDelete();

					} while ( numberOfAdvisorToDelete < 0 );

					// del Advisor and regenerate file
					helha.delAdvisor(numberOfAdvisorToDelete);

				/*********************************** ADD SCHOOL *************************************/
				} else if ( choiceMenuGroup == 5 ) {
					
					string name, type;

					Display::instruction("ENTREZ LE NOM DE L ECOLE");
					getline( cin , name );

					Display::instruction("ENTREZ LE TYPE D ECOLE");
					getline( cin , type );

					School sc = School( name, name );
					helha.addSchool( sc );



				/*********************************** DEL SCHOOL *************************************/
				} else if ( choiceMenuGroup == 6 ) {

					int numberOfSchoolToDelete=-1;

					// only number or Retry
					do {

						// Display list of Advisor for the choice
						numberOfSchoolToDelete = helha.displaySchoolForDelete();

					} while ( numberOfSchoolToDelete < 0 );

						// del Advisor and regenerate file
						helha.delSchool(numberOfSchoolToDelete);

				}

			
			} while( choiceMenuGroup!=0 );

		/********************************** START MENU DIRECTOR *************************************/
		} else if ( choiceMenuStart == 2 ){

			int choiceMenuDirector = -1;

			// select school to administrate
			School schoolSelected;
			schoolSelected = helha.displaySchoolForSelect();

			

		

			do {

				choiceMenuDirector = Display::menuDirector();

				// display employees
				if ( choiceMenuDirector == 1 ){
					
					vector<string> menu;
					menu.push_back( string("TOUT LE MONDE") );
					menu.push_back( string("DIRECTEUR") );
					menu.push_back( string("SECRETAIRE") );
					menu.push_back( string("ENSEIGNANTS") );
					menu.push_back( string("ETUDIANT") );
					menu.push_back( string("HYBRID") );
					menu.push_back( string("NOMBRE DE PERSONE PAR TYPE") );

					int choiceUserPersonToDisplay = -1;
					do{

						Display::fillFullLine('-');
						Display::centerOutputString("CHOISISSEZ QUI AFFICHER");
						Display::fillFullLine('-');

						Treatment::makeMenu(menu);
						Display::pauseAtBottom( 35-4-menu.size() );

						cin >> choiceUserPersonToDisplay;
					
					} while ( !Treatment::checkCinIntValidity( 0,6,choiceUserPersonToDisplay ) );

					system("cls");
					switch ( choiceUserPersonToDisplay ){
						case 0 :
							// display all
							schoolSelected.displayPerson();
						case 1 :
							schoolSelected.displayPerson( string("director") );
							break;
						case 2 :
							schoolSelected.displayPerson( string("secretary") );
							break;
						case 3 :
							schoolSelected.displayPerson( string("teacher") );
							break;
						case 4 :
							schoolSelected.displayPerson( string("student") );
							break;
						case 5 :
							schoolSelected.displayPerson( string("hybrid") );
							break;
						case 6 :
							// display statistics
							schoolSelected.displayTotalPersonPerType();
					}
					system("pause");
					system("cls");

				// fire secretary
				} else if ( choiceMenuDirector == 2 ){



				// fire teacher
				} else if ( choiceMenuDirector == 3 ){



				// hire secretary
				} else if ( choiceMenuDirector == 4 ){

					string name , firstName , street , town;
					int hourToDo, boxNumber , number , postalCode;

					Display::instruction("ENTREZ LE NOM");
					getline( cin , name );


					Display::instruction("ENTREZ LE PRENOM");
					getline( cin , firstName );

					do {
						Display::instruction("ENTREZ LE NOMBRE D'HEURE A PRESTER PAR SEMAINE");
						cin >> hourToDo;
						goodOrRetry = Treatment::checkCinIntValidity(0,50,hourToDo);
					} while ( !goodOrRetry );


					Display::instruction("ENTREZ LA RUE");
					getline( cin , street );


					do {
						Display::instruction("ENTREZ LA BOITE POSTALE ( 0 si aucune )");
						cin >> boxNumber;
						goodOrRetry = Treatment::checkCinIntValidity(0,9999,boxNumber);
					} while ( !goodOrRetry );

					do {
						Display::instruction("ENTREZ LE NUMERO");
						cin >> number;
						goodOrRetry = Treatment::checkCinIntValidity(0,9999,number);
					} while ( !goodOrRetry );


					Display::instruction("ENTREZ LA VILLE");
					getline( cin , town );

					do {
						Display::instruction("ENTREZ LE CODE POSTAL");
						cin >> postalCode;
						goodOrRetry = Treatment::checkCinIntValidity(0,9999,postalCode);
					} while ( !goodOrRetry );


					Secretary* secretary = new Secretary( name, firstName, hourToDo, boxNumber, number, postalCode, street, town );
					schoolSelected.hire( secretary );

					system("cls");
					Display::instruction("NOUVELLE SECRETAIRE ENREGISTREE");
					system("pause");


				// hire teacher
				} else if ( choiceMenuDirector == 5 ){

					string name , firstName , street , town;
					int hourToDo, seniority, boxNumber , number , postalCode;

					Display::instruction("ENTREZ LE NOM");
					getline( cin , name );


					Display::instruction("ENTREZ LE PRENOM");
					getline( cin , firstName );


					Display::instruction("ENTREZ LA RUE");
					getline( cin , street );

					do {
						Display::instruction("ENTREZ LE NOMBRE D'HEURE DE COURS A DONNER PAR SEMAINE");
						cin >> hourToDo;
						goodOrRetry = Treatment::checkCinIntValidity(0,100,hourToDo);
					} while ( !goodOrRetry );

					do {
						Display::instruction("ENTREZ SON ANCIENNETE ( EN ANNEE )");
						cin >> seniority;
						goodOrRetry = Treatment::checkCinIntValidity(0,50,seniority);
					} while ( !goodOrRetry );

					do {
						Display::instruction("ENTREZ LA BOITE POSTALE ( 0 si aucune )");
						cin >> boxNumber;
						goodOrRetry = Treatment::checkCinIntValidity(0,9999,boxNumber);
					} while ( !goodOrRetry );

					do {
						Display::instruction("ENTREZ LE NUMERO");
						cin >> number;
						goodOrRetry = Treatment::checkCinIntValidity(0,9999,number);
					} while ( !goodOrRetry );


					Display::instruction("ENTREZ LA VILLE");
					getline( cin , town );

					do {
						Display::instruction("ENTREZ LE CODE POSTAL");
						cin >> postalCode;
						goodOrRetry = Treatment::checkCinIntValidity(0,9999,postalCode);
					} while ( !goodOrRetry );


					Teacher* teacher = new Teacher( name, firstName, hourToDo, seniority, boxNumber, number, postalCode, street, town );
					schoolSelected.hire( teacher );

					system("cls");

					Display::instruction("NOUVEL ENSEIGNANT ENREGISTRE");
					system("pause");

				}

				
			} while ( choiceMenuDirector > 0 );

		/********************************* START MENU SECRETARY *************************************/
		} else if ( choiceMenuStart == 3 ){

			Display::menuSecretary();

		/****************************** START MENU COMPUTER SCIENTIST  *****************************/
		} else if ( choiceMenuStart == 4 ){

			Display::menuComputerScientist();

		}

	} while( choiceMenuStart!=0 );

	//system("pause");
	//system("cls");
}