#pragma once

#include <string>

class User
{
public:
	User();
	void displayData();
	~User();
private:
	std::string name_;
	bool subscriber_;

};

