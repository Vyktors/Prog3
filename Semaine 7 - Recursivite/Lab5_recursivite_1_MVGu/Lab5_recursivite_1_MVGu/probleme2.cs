using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_recursivite_1_MVGu
{
    class probleme2
    {
        //Déclaration des constantes
        const int SIZE = 20;
        const double POURCENTAGETACHE = 10; //Établi le pourcentage de taches dans le tableau

        //Déclaration des variables
        bool[,] grid;
        Random nbrRdm;
        int nbrTaches;
        int nbrCases;

        //S'exécute qu'une seule fois lors du démarrage du programme
        public probleme2()
        {
            grid = new bool[SIZE, SIZE];
            nbrRdm = new Random();
            nbrCases = grid.GetLength(0) * grid.GetLength(1);
        }

        //S'exécute chaque fois que l'utilisateur choisi de partir le problème #2
        public void Start()
        {
            //Réinitialisation
            IniGrid();




            //System.Threading.Thread.Sleep(5000);
            


        }

        //remet à faux toutes les cases de grid
        private void IniGrid()
        { 
            double devientTache;
            for (int col = 0; col < grid.GetLength(0); col++)
            {
                for (int row = 0; row < grid.GetLength(1); row++)
                {
                    //System.Threading.Thread.Sleep(12);        //Peut être décommenté pour donner un effet
                    devientTache = nbrRdm.Next(0, 100);
                    if(devientTache < POURCENTAGETACHE)
                    {
                        grid[col, row] = true;
                    }
                    else
                    {
                        grid[col, row] = false;
                    }
                    //Console.Clear();                          //Peut être décommenté pour donner un effet
                    //ShowGrid();                               //Peut être décommenté pour donner un effet
                }
            }
            ShowGrid();
        }

        private void ShowGrid()
        {
            const string CARACTERE_TACHE = "X";
            const string CARACTERE_VIDE = "\u00B7";
            const string CARACTERE_BORDURE_HAUT_COIN_GAUCHE = " ";
            const string CARACTERE_BORDURE_HAUT = "_";
            const string CARACTERE_BORDURE_HAUT_COIN_DROIT = " ";

            const string CARACTERE_BORDURE_BAS_COIN_GAUCHE = " ";
            const string CARACTERE_BORDURE_BAS = "\u035E";
            const string CARACTERE_BORDURE_BAS_COIN_DROIT = " ";

            const string CARACTERE_BORDURE_COTE = "|";


            String sCaractereAjoute = "";

            String[] LigneAffichage = new String[grid.GetLength(0)];



            Console.WriteLine("Nombre de taches: " + nbrTaches);


            for (int iColonne = 0; iColonne < SIZE; iColonne++)
            {
                for (int iligne = 0; iligne < SIZE; iligne++)
                {

                    if (grid[iColonne, iligne] == true)
                    {
                        sCaractereAjoute = CARACTERE_TACHE;
                    }
                    else
                    {
                        sCaractereAjoute = CARACTERE_VIDE;
                    };

                    LigneAffichage[iligne] = LigneAffichage[iligne] + sCaractereAjoute;
                }


            }

            Console.WriteLine(CARACTERE_BORDURE_HAUT_COIN_GAUCHE + Repetechar(SIZE, CARACTERE_BORDURE_HAUT) + CARACTERE_BORDURE_HAUT_COIN_DROIT);
            for (int i = 0; i < SIZE; i++)
            {
                Console.WriteLine(CARACTERE_BORDURE_COTE + LigneAffichage[i] + CARACTERE_BORDURE_COTE);
            }
            Console.WriteLine(CARACTERE_BORDURE_BAS_COIN_GAUCHE + Repetechar(SIZE, CARACTERE_BORDURE_BAS) + CARACTERE_BORDURE_BAS_COIN_DROIT);
            Console.WriteLine("");           
            
        }

        string Repetechar(int nbrIteration, string symbole)
        {
            string text = "";

            for (int i = 0; i < nbrIteration; i++)
            {
                text += symbole;
            }
            return text;
        }
    }
}
