#pragma once
#include <string>
#include <vector>

using namespace std;

class Address;
class Personne;
class Client;
class Personne;
class Client;
class Provider;
class Order;
class Equipment;

class Address{
public:
	Address();
	Address(int number, int postalCode,string street, string town);
	void display();
	~Address();
private:
	int number_,postalCode_;
	string street_,town_;

};


class Magasin{
public:
	Magasin(string name, Address adr);
	~Magasin();
	void addStock(Equipment &a);
	void addClient(Client &a);
	void addProvider(Provider &a);
	void displayInformations();
	void displayStock();
private:
	string name_ ;
	Address address_;
	vector<Equipment> stock_;
	vector<Client> clients_;
	vector<Provider> provider_;
};






class Personne{
public:
	Personne(string nom, string mail, int phoneNumber, Address const &adr);
	~Personne();
	void displayInformations();
private :
	string name_,mail_;
	int phoneNummer_;
	Address address_;

};



class Client:public Personne{
public:
	Client(string nom, string mail, int phoneNumber, Address &adr);
	~Client();
	void displayInformations();
	void displayOrder();
	void makeOrder(Order const &order);
	static int idClient;
private :
	int clientNummer_;

};

class Provider:public Personne{
public:
	Provider(int tvaNummer, string location, string nom, string mail, int phoneNumber, Address &adr);
	~Provider();
	void displayInformations();
	void addStock();
private:
	int tvaNummer_;
	string location_;
};

class Order{
public:
	Order();
	void displayInformations();
	void addEquipment();
	void displayOrder();
	~Order();
private:
	int amount_;
};

class Equipment{
public:
	Equipment(string name, int price, int amount);
	~Equipment();
	void displayInformations();
private:
	string name_;
	int price_,amountStock_;
};
