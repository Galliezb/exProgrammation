#pragma once
class Airstrip
{
public:
	Airstrip(int length, int composition, int nummer);
	bool compareLength(Airstrip &a);
	bool compareComposition(Airstrip &a);
	bool compareNummer(Airstrip &a);
	void displayInformation();
	~Airstrip();
	static int stripCreated;
private:
	int length_,composition_,nummer_;
};

