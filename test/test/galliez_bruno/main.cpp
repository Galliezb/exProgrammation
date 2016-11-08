#include "Circulation.h"


void main(){

	// creation de l'objet Circulation
	Circulation circulation = Circulation("Paris",2016,10,27);

	// cr�er tout type de v�hicule
	Bike bike1 = Bike("VTT",2,40);
	Car car1 = Car("Toyota",Tank(40),4,190);
	Truck truck1 = Truck(1500,10,90);

	// Ajouter les objets v�hicule � la circulation
	circulation.addVehicle(bike1);
	circulation.addVehicle(car1);
	circulation.addVehicle(truck1);

	// Afficher ls informatons de la circulation
	cout << "Afficher les **informations** de la Circulation : " << endl << endl;
	circulation.afficher();
	system("pause");

	// afficher tous les v�hicule de la circulation
	// Afficher ls informatons de la circulation
	system("cls");
	cout << "Afficher les **vehicule** de la Circulation : " << endl << endl;
	circulation.displayVehicle();
	system("pause");

	// afficher le nombre de camion cr��
	system("cls");
	cout << "Afficher le nombre de camion cree : " << endl;
	cout << "Number Object Truck created : " << Truck::numberObjectCreated << endl;
	system("pause");


	// comparer deux v�lo
	Bike bike2 = Bike("children",4,5);
	Bike bike3 = Bike("VTT",2,50);

	system("cls");
	cout << "Comparaison de 2 velos :  " << endl << endl;


	// deux v�lo non identique
	if ( bike1.compare( bike1, bike2) ){
		cout << "Bike1 and Bike2 are identical" << endl;
	} else {
		cout << "Bike1 and Bike2 are not identical" << endl;
	}
	// deux v�lo identique
	if ( bike1.compare( bike1, bike3) ){
		cout << "Bike1 and Bike3 are identical" << endl;
	} else {
		cout << "Bike1 and Bike3 are not identical" << endl;
	}
	system("pause");

}