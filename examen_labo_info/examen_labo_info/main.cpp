#include "lesclasses.h"


void main(){
	bool quitteMenu = true;

	// Cr�er le coll�ge
	College col1("Sainte-Marie", "http://Sainte_Marie.be/");

	// Cr�er des d�partements qui constitue le coll�ge
	col1.addDepartement(1,"Info");
	col1.addDepartement(2,"Electro");
	col1.addDepartement(3,"GRH");

	// cr�er tout type de personnes
	Personne pers1("nomp1","prenomp1","telp1","mailp1");
	Personne pers2("nomp2","prenomp2","telp2","mailp2");
	Etudiant etud1("nomEtu1","prenomEtu1","telEtu1","mailEtu1",1982);
	Etudiant etud2("nomEtu2","prenomEtu2","telEtu2","mailEtu2",1970);
	Enseignant ense1("nomEnse1","prenomEnse1","telEnse1","mailEnse1");
	Enseignant ense2("nomEnse2","prenomEnse2","telEnse2","mailEnse2");


	// Ajouter les personnes aux d�partements
	vector<Departement>* accesDpt = col1.getDepartement();
	accesDpt->at(0).ajouterPersonne(&pers1);
	accesDpt->at(0).ajouterPersonne(&pers2);
	Personne* etu1 = &etud1;
	accesDpt->at(0).ajouterPersonne(etu1);
	Personne* etu2 = &etud2;
	accesDpt->at(0).ajouterPersonne(etu2);
	Personne* ens1 = &ense1;
	accesDpt->at(0).ajouterPersonne(ens1);
	Personne* ens2 = &ense2;
	accesDpt->at(0).ajouterPersonne(ens2);

	// Cr�er des mati�res et les associer aux enseignants
	Matiere mat1(1,"lab info");
	Matiere mat2(2,"reseau");
	Matiere mat3(3,"electro");
	ense1.addMatiere(mat1);
	ense1.addMatiere(mat3);
	ense2.addMatiere(mat2);
	ense2.addMatiere(mat3);


	//Cr�er des salles et les associer aux mati�re
	Salle s1("Labo",50);
	Salle s2("info",40);
	Salle s3("c24",35);
	mat1.addSalle(s1);
	mat2.addSalle(s1);
	mat3.addSalle(s3);

	// Cr�er des notes et les associer aux etudiants et aux matieres
	Note n1(16.75,1);
	Note n2(11.54,1);
	Note n3(8.54,2);
	Note n4(11.9,2);
	etud1.ajouterNote(n1);
	etud1.ajouterNote(n3);
	etud2.ajouterNote(n2);
	etud2.ajouterNote(n4);

	// calculer la moyenne par matiere
	cout << "Moyenne etudiant 1 en lab info : " << etud1.calculerMoyenneParMatiere(1) << endl;
	cout << "Moyenne etudiant 1 en reseau : " << etud2.calculerMoyenneParMatiere(2) << endl;

	// calcul de moyenne g�n�rale
	cout << "Moyenne G�n�rale etudiant 1 : " << etud1.calculerMoyenneGenerale() << endl;
	cout << "Moyenne G�n�rale etudiant 2 : " << etud2.calculerMoyenneGenerale() << endl;

	// Fiche siganl�tique
	etu1->afficher();
	ens1->afficher();



	system("pause");
}