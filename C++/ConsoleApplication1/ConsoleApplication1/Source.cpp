#include <stdio.h>
#include <stdlib.h>

void main(){

	int reponse;
	int choix=1;

	do{

		system("cls");
		printf("** Si vous souhaitez dessiner un triangle,    tapez 1 **\n");
		printf("** Si vous souhaitez dessiner un losange,     tapez 2 **\n");
		printf("** Si vous souhaitez dessiner un carre,       tapez 3 **\n");
		printf("** Si vous souhaitez dessiner un rectangle,   tapez 4 **\n");
		printf("** Si vous souhaitez quitter le menu,         tapez 5 **\n");

		printf("Tapez le chiffre de votre choix : ");
		scanf_s("%d", &reponse);

		if (reponse == 1)
		{
			printf("Combien voulez-vous de ligne dans votre triangle : ");
			scanf_s("%d", &choix);

			for (int compteur = 0; compteur < choix; compteur++)
			{

				// choix == 5
				int espace = choix-compteur;
				for (int i=espace-1; i>0; i--){
					printf("-");
				}

				int startetoile = compteur*-2;
				for ( int etoile=(choix*2-1)+startetoile; etoile<=choix*2-1; etoile++){
					printf("*");
				}
				printf("\n");

			}
			printf("\n");

		}
		system("pause");
	} while (reponse != 5);
	system("pause");
}