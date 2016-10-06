#pragma once
#include <vector>

#include "User.h"

using namespace std;

class Bus
{
public:
	Bus();
	void displayData();
	int upWeight( int weight = 1000 );
	bool compareBus( const Bus&, const Bus& );
	Bus beHeaviest( const Bus&, const Bus& );
	void displayAllUser();
	void addUser();
	~Bus();
private:
	int registrationNumber_,startupYear_,totalWeight_;
	// push_back() pour ajouter une valeur à la fin
	// pop_back() retire la dernière allocation du tableau
	// usager_.size() renverra la taille du tableau
	vector<User> user_;
};

