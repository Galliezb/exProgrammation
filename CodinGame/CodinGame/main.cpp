#include <string>
#include <iostream>

using namespace std;

class Chanson;
class Album;

class Chanson {
public:
	Chanson();
	Chanson(string T, int L);
	string getTitre() const;
	int getDuree() const;
private:
	string Titre; // Titre de la chanson
	int Duree; // Duree de la chanson
};
class Album {
public:
	Album(string T, string A,int nombreChansons);
	void AjoutChanson(const Chanson& T);
	Chanson getChanson(int Position) const;
	int getnombreChansons() const;
	~Album();
private:
	string Titre; // Titre de l'album
	string Auteur; // Auteur de l'album
	int nombreChansons; // Nombre de chansons dans l'album
	Chanson* ListeEcoute; // La liste des chansons
	int element ;
};
Album::Album(string T, string A, int nT) {
	Titre = T;
	Auteur = A;
	nombreChansons = nT;
	ListeEcoute = new Chanson[nT];
	element=0;
}
void Album::AjoutChanson(const Chanson & T){
}
Chanson Album::getChanson(int Position) const{
	return Chanson();
}
int Album::getnombreChansons() const{
	return 0;
}
Album::~Album() {
	delete [] ListeEcoute;
	cout << "deconstructeur album" << endl;
}
int DureeGlobale(Album CD) {
	int DureeTotale = 0;
	for (int Index = 0; Index < CD.getnombreChansons(); Index++) {
		DureeTotale += CD.getChanson(Index).getDuree();
	}
	return DureeTotale;
}

void main(){
	Album a("T","A",5);
	DureeGlobale(a);
	system("pause");
}

Chanson::Chanson(){
}

Chanson::Chanson(string T, int L){
}

string Chanson::getTitre() const{
	return string();
}

int Chanson::getDuree() const{
	return 0;
}
