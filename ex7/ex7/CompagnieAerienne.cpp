// N° 41 inclusion au début de fichier
#include "CompagnieAerienne.h"

// N° 42 
// N°47 utilisation variable global au minimum
int nb ; //variable globale pour compter le nombre de compagnie aérienne

void compagnieAerienne::initialisationcompagnieaerienne(int ii, string nn, string vv){

	i_=ii ;

	n_=nn ;

	v_=vv ;

	if (nb<max) nb++;

	else cout<< "Nombre maximum de compagnie aérienne atteint!!!";

}

void compagnieAerienne::afficher(){

	cout<< "Code :"<<i_<<endl ;

	cout<< "Nom :"<<n_<<endl ;

	cout<<"Ville : "<<v_<<endl ;

}
	
// N° 5 afficherNombreCompagnieAerienne
void compagnieAerienne::afficherNombre(){

	cout<< "Nombre de compagnie aérienne :"<<nb<<endl ;

}