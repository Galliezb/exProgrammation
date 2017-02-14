/*
Modifier l�exemple sur les deques pour qu�il respecte les demandes suivantes :
1) Afficher l��l�ment d�indice 1 de 2 fa�ons diff�rentes
2) Supprimer le dernier �l�ment
3) Utiliser un it�rateur pour afficher le contenu de la deque 
*/

#include <deque>
#include <iostream>
#include <iterator>
using namespace std;

typedef deque<int> int_deque;
void main(){
	int_deque Q;//idem vector sauf insertion en plus en ent�te du vecteur
	Q.push_back(5);
	Q.push_front(3);
	Q.insert(Q.begin() + 1, 2);
	copy(Q.begin(), Q.end(), ostream_iterator<int>(cout, ";"));
	cout<<endl;
	//les valeurs 1 2 3 sont affich�es
	Q[2] = 0;
	copy(Q.begin(), Q.end(), ostream_iterator<int>(cout, " "));
	cout<<endl;
	//les valeurs 1 2 0 sont affich�es

	// 1) Afficher l��l�ment d�indice 1 de 2 fa�ons diff�rentes
	cout << "indice 1 : " << Q.front() << endl;
	cout << "indice 1 : " << Q.front() << endl;

	// 2) Supprimer le dernier �l�ment
	Q.pop_back();

	// 3) Utiliser un it�rateur pour afficher le contenu de la deque
	
	deque<int>::iterator it;  //Un it�rateur sur une deque d'entiers
	
	cout << "***********" << endl;
	for(it = Q.begin(); it!=Q.end(); ++it) { //Et on it�re sur la deque
		cout << *it << endl;    //On acc�de � l'�l�ment point� via l'�toile
	}

	system("pause");
}

