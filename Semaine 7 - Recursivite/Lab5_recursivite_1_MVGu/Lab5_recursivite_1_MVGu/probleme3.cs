//Problème #3  Récursivité , Tour de Hanoï
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_recursivite_1_MVGu
{
    class probleme3
    {
        //Déclaration des constantes
        const string TITLE3 = "LES TOURS DE HANOÏ";
        const int MAXDISQUES = 10;
        
        //Déclaration des variables
        int nbrDisques;
        int nbrDep;
        string nomTour1;
        string nomTour2;
        string nomTourPar;
        
        //S'exécute qu'une seule fois lors du démarrage du programme
        public probleme3()
        {
            nomTour1 = "A";
            nomTour2 = "B";
            nomTourPar = "X";
        }

        //S'exécute chaque fois que l'utilisateur choisi de partir le problème #3
        public void Start()
        {
            //(Ré) Initialisation
            nbrDep = 0;
            

            //
            Console.WriteLine(centerText(TITLE3));
            Console.WriteLine("\nCombien de disques voulez vous déplacer? (Entre 1 et " + MAXDISQUES + ")");
            do
            {
                //Gère si l'utilisateur entre un charactère qui n'est pas un chiffre
                nbrDisques = 0;
                try
                {
                    Console.Write("\nNombre de disques : ");
                    nbrDisques = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Veuillez entrer un nombre!");
                }
                //Gère si l'utilisateur entre un charactère qui ne se trouve pas entre 1 et MAXDISQUES
                if (nbrDisques > MAXDISQUES || nbrDisques == 0)
                {
                    Console.WriteLine("Veuillez entrer un nombre entre 1 et "+ MAXDISQUES +"!");
                }
            } while (nbrDisques == 0 || nbrDisques > MAXDISQUES);

            Tours(nbrDisques, nomTour1, nomTour2, nomTourPar);

            Console.WriteLine("\nDéplacement de " + nbrDisques + " disques de la tour " + nomTour1 + " à la tour " + nomTour2 + " par la tour " + nomTourPar + " se fait en " + nbrDep + " déplacements!" );
        }

        //Algo
        private void Tours (int _nbrDisques, string Tour1, string Tour2, string TourPar)
        {
            if (_nbrDisques == 1)
            {
                Transport(1, Tour1, Tour2);
            }
            else
            {
                Tours(_nbrDisques - 1, Tour1, TourPar, Tour2);
                Transport(_nbrDisques, Tour1, Tour2);
                Tours(_nbrDisques - 1, TourPar, Tour2, Tour1);                   
            }
        }

        //Affiche le transport
        private void Transport(int disque, string Tour1, string Tour2)
        {
            nbrDep++;
            Console.WriteLine("Déplacement #"+ nbrDep +": Transporte un disque de la tour " + Tour1 + " à la tour " + Tour2);
        }
        //Retourne le text centré par rapport à la largeur de la fenêtre
        private string centerText(string text)
        {
            string centeredText;
            centeredText = String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text);
            return centeredText;
        }
    }
}
