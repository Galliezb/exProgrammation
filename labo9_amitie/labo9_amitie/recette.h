#pragma once

#include <string>
#include <iostream>
#include <vector>

using namespace std;

class Ingredient {
public:
	Ingredient(string nature,int calorie, int glucide, int proteine, int lipide, string quantite);
	// on donne l'accès à cette surcharge sur ingrédient
	friend class Recette;
	friend iostream& operator<< (iostream &i, Recette &r);
	~Ingredient();
private:
	string nature_;
	int calorie_;
	int glucide_;
	int proteine_;
	int lipide_;
	string quantite_;
};

class Restaurant {
public:
	Restaurant(string nom,string rue,int numero,string ville,int codePostal);
	friend class Recette;

	~Restaurant();
private:
	string nom_;
	string rue_;
	int numero_;
	string ville_;
	int codePostal_;
};

class Recette{
public:
	Recette(int code,string nom,string typePlat,int niveau,int tpsPreparation,int tpsCuisson,string modeCuisson,string explication,Restaurant &r, vector<Ingredient>& v);
	// on donne l'accès à cette fonction de surcharge sur la class Recette
	friend iostream& operator<< (iostream &i, Recette &r);
	void cuisinerPour(int nbrPersonne);
	~Recette();
private:
	int code_;
	string nom_;
	string typePlat_;
	int niveau_;
	int tpsPreparation_;
	int tpsCuisson_;
	string modeCuisson_;
	string explication_;
	vector<Restaurant>& restaurant_;
	vector<Ingredient>& ingredients_;
};

iostream& operator<< (iostream& i, Recette& r);