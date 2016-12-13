/*
Modifier l’exemple sur les deques pour qu’il respecte les demandes suivantes :
1) Afficher l’élément d’indice 1 de 2 façons différentes
2) Supprimer le dernier élément
3) Utiliser un itérateur pour afficher le contenu de la deque 
*/

#include <deque>
#include <iostream>
#include <iterator>
using namespace std;

typedef deque<int> int_deque;
void main(){
	int_deque Q;//idem vector sauf insertion en plus en entête du vecteur
	Q.push_back(5);
	Q.push_front(3);
	Q.insert(Q.begin() + 1, 2);
	copy(Q.begin(), Q.end(), ostream_iterator<int>(cout, ";"));
	cout<<endl;
	//les valeurs 1 2 3 sont affichées
	Q[2] = 0;
	copy(Q.begin(), Q.end(), ostream_iterator<int>(cout, " "));
	cout<<endl;
	//les valeurs 1 2 0 sont affichées

	// 1) Afficher l’élément d’indice 1 de 2 façons différentes
	cout << "indice 1 : " << Q.front() << endl;
	cout << "indice 1 : " << Q.front() << endl;

	// 2) Supprimer le dernier élément
	Q.pop_back();

	// 3) Utiliser un itérateur pour afficher le contenu de la deque
	
	deque<int>::iterator it;  //Un itérateur sur une deque d'entiers
	
	cout << "***********" << endl;
	for(it = Q.begin(); it!=Q.end(); ++it) { //Et on itère sur la deque
		cout << *it << endl;    //On accède à l'élément pointé via l'étoile
	}

	system("pause");
}

