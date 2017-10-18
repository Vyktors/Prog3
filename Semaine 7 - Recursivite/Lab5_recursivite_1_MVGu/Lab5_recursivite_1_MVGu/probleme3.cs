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
        const string title3 = "LES TOURS DE HANOÏ";

        //Déclaration des variables
        int nbrDisques;

        //S'exécute qu'une seule fois lors du démarrage du programme
        public probleme3()
        {

        }

        //S'exécute chaque fois que l'utilisateur choisi de partir le problème #3
        public void Start()
        {
            //(Ré) Initialisation
            

            //
            Console.WriteLine(centerText(title3));
            Console.WriteLine("\nCombien de disques voulez vous déplacer? (Entre 1 et 10)");
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
                //Gère si l'utilisateur entre un charactère qui ne se trouve pas entre 1 et 10
                if (nbrDisques > 10 || nbrDisques == 0)
                {
                    Console.WriteLine("Veuillez entrer un nombre entre 1 et 10!");
                }
            } while (nbrDisques == 0 || nbrDisques > 10);
            
        }





        //Retourne le text centré par rapport à la largeur de la fenêtre
        string centerText(string text)
        {
            string centeredText;
            centeredText = String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text);
            return centeredText;
        }
    }
}
