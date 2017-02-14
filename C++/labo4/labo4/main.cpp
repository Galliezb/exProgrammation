#include "ClassMagasin.h"

void main(){

	// créer un objet magasin
	Address adrMagasin(54,5469,"rue entreprise en faillites","Succes");
	Magasin top("TorcheLand",adrMagasin);

	// crée un stock  et ajoute un stock au magasin 
	Equipment clavier("logitech",69,15);
	top.addStock(clavier);

	// crée tout type de personnes
	Address adrJack(7,8960,"rue des lapins maboules","carotteTown");
	Client client = Client("JackLeClient","Jack@youporn.com",455696969,adrJack);

	Address adrVendeur(69,45690,"Rue des arnaqueurs","Danlfion");
	Provider provider = Provider(123456789,"Zoning fou","Logipastech","camarchepas@ontaseu.dtc",476857412,adrVendeur);

	//  et  les ajoute au magasin 
	top.addClient(client);
	top.addProvider(provider);


	// affiche les informations du magasin 
	top.displayInformations();
	
	system("pause");
}