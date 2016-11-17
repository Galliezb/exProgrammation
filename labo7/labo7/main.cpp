#include "Ai.h"

void main(){

	// creation d'une adresse
	Address adr = Address(7,"rue des lapins vert","59685","CarotteVille");
	// creation d'un Agence Immobiliere
	Ai ai = Ai("056",adr,"056/56.56.56");

	// creation d'un bien
	Bien *b1 = new Maison(true,15);
	Bien *b2 = new Appartement(10,150);

	// creation des personnes
	Personne *p1 = new LocProp("Dutruand","Jarnaque",15,"0476/59.65.87",2654,"M");
	Personne *p2 = new Locataire("Baltazar","Carteque",25,"0666/66.66.66",666);
	Personne *p3 = new Proprietaire("Constantine","Bourtak",25,"0489/56.34.67","M");

	// affichage information AI
	ai.afficher();
	system("pause");
	system("cls");
	
	// Affichage biens Ai
	ai.afficherBien();
	// ajouter les biens a l'ai + afficher
	ai.ajouterBien(b1);
	ai.ajouterBien(b2);
	ai.afficherBien();

	// Afficher personnes AI
	ai.afficherPersonne();
	// ajouter des personnes a l'AI  + afficher
	ai.ajouterPersonne(p1);
	ai.ajouterPersonne(p2);
	ai.ajouterPersonne(p3);
	ai.afficherPersonne();

	// 


	delete b1,b2,p1,p2;

}