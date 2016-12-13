#include "lesclasses.h"

template <class T> class Point{
	T x,y;
public :
	Point(T abs,T ord){x=abs;y=ord;}
	void affiche();
};
template <class T> void Point<T>::affiche(){
	cout<<"Coordonnees :("<<x<<", "<<y<<")"<<endl;
};

void main(){

	Point<char> pi(60,65);
	pi.affiche();

	// modification de ce qui suit pour une sortie en INT
	Point<int> pi2(60,65);
	pi2.affiche();

	system("pause");

}