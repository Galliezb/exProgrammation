#pragma once

#include <string>

using namespace std;

class User
{
public:
	User();
	void displayData();
	~User();
private:
	string name_;
	bool subscriber_;

};

