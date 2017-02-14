#include <iostream>

#include "ClassMagasin.h"



Magasin::Magasin(string name, Address adr){

	name_ = name;
	address_ = adr;
}

Magasin::~Magasin(){
	cout << "destructeur magasin" << endl;
}

void Magasin::addStock(Equipment &e){

	system("cls");
	cout << "Ajout au stock. Infos detaillez ci-dessous : " << endl;
	e.displayInformations();
	stock_.push_back(e);
	system("pause");
	system("cls");
}



void Magasin::addClient(Client &c){

	system("cls");
	cout << "Ajout d'un client." << endl;
	clients_.push_back(c);

}


void Magasin::addProvider(Provider &p){

	system("cls");
	cout << "Ajoute 1 Provider " << endl;
	provider_.push_back(p);

}

void Magasin::displayInformations(){
	system("cls");
	cout << "name magasin : " << name_ << endl;
	address_.display();
	system("pause");
	system("cls");
	cout << "*************************************************" << endl;
	cout << "******************* CLIENTS *********************" << endl;
	cout << "*************************************************" << endl;
	for each (Client c in clients_){
		c.displayInformations();
		system("pause");
		system("cls");
	}
	cout << "*************************************************" << endl;
	cout << "****************** PROVIDER *********************" << endl;
	cout << "*************************************************" << endl;
	for each (Provider c in provider_){
		c.displayInformations();
		cout << "****************************************" << endl;
		system("pause");
		system("cls");
	}
	Magasin::displayStock();
}

void Magasin::displayStock(){
	system("cls");
	system("pause");
	cout << "*************************************************" << endl;
	cout << "******************** STOCK **********************" << endl;
	cout << "*************************************************" << endl;
	for each (Equipment c in stock_){
		c.displayInformations();
	}
}


Address::Address(){
}

Address::Address(int number, int postalCode, string street, string town){

	number_ = number;
	postalCode_ = postalCode;
	street_ = street;
	town_ = town;

}



void Address::display(){

	cout << "Address : " << endl;
	cout << "N° " << number_ << street_ << endl;
	cout << postalCode_ << town_ << endl;

}



Address::~Address(){
}

Equipment::Equipment(string name, int price, int amount){

	name_ = name;
	price_ = price;
	amountStock_ = amount;

}

Equipment::~Equipment(){
	cout << "destructeur equipment" << endl;
}

void Equipment::displayInformations(){
	cout << "name : " << name_ << endl;
	cout << "price : " << price_ << endl;
	cout << "Amount in stock : " << amountStock_ << endl;
}

Personne::Personne(string name, string email, int phoneNumber, Address const &adr){

	name_ = name;
	mail_ = mail_;
	phoneNummer_ = phoneNumber;
	address_ = adr;

}

Personne::~Personne(){

	cout << "Destructeur classe Personne" << endl;

}

void Personne::displayInformations(){

	cout << "Name : " << name_ << endl;
	cout << "Mail : " << mail_ << endl;
	cout << "Phone Nummer : " << phoneNummer_ << endl;
	address_.display();
	


}


int Client::idClient = 0;

Client::Client(string nom, string mail, int phoneNumber, Address & adr):Personne(nom,mail,phoneNumber,adr){

	Client::idClient++;
	clientNummer_ = Client::idClient;

}

Client::~Client(){

	cout << "Destructeur de client" << endl;

}

void Client::displayInformations(){
	system("cls");
	cout << "Id client : " << clientNummer_ << endl;
	Personne::displayInformations();
}

Provider::Provider(int tvaNummer, string location, string nom, string mail, int phoneNumber, Address & adr):Personne(nom,mail,phoneNumber,adr){

	tvaNummer_ = tvaNummer;
	location_ = location;

}

Provider::~Provider(){

	cout << "Destructeur du Provider" << endl;

}

void Provider::displayInformations(){

	cout << "Infos provider : " << endl;
	Personne::displayInformations();
	cout << "Tva : " << tvaNummer_ << endl << "Location : " << location_ << endl;

}
