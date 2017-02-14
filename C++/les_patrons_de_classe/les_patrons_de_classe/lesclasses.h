#pragma once
/*
class Point {
public:
	Point(int x, int y);
	void affiche();
private:
	int abs_,ord_;

};

class Point {
public:
	Point(double x, double y);
	void affiche();
private:
	double abs_,ord_;

};
*/
// pourra s'ecrire plus simplement avec les templates
//  contrainte des mod�eles, il faudra d�finir les fonction dans le .h selon le mod�le car pas de type utilisable possible.
template < class T> class Point{
public:
	Point(T x, T y);
	void affiche();
private :
	T abs_,ord_;
};

