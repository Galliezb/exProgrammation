// N� 41 inclusion au d�but de fichier
#include "CompagnieAerienne.h"

// N� 42 
// N�47 utilisation variable global au minimum
int nb ; //variable globale pour compter le nombre de compagnie a�rienne

void compagnieAerienne::initialisationcompagnieaerienne(int ii, string nn, string vv){

	i_=ii ;

	n_=nn ;

	v_=vv ;

	if (nb<max) nb++;

	else cout<< "Nombre maximum de compagnie a�rienne atteint!!!";

}

void compagnieAerienne::afficher(){

	cout<< "Code :"<<i_<<endl ;

	cout<< "Nom :"<<n_<<endl ;

	cout<<"Ville : "<<v_<<endl ;

}
	
// N� 5 afficherNombreCompagnieAerienne
void compagnieAerienne::afficherNombre(){

	cout<< "Nombre de compagnie a�rienne :"<<nb<<endl ;

}