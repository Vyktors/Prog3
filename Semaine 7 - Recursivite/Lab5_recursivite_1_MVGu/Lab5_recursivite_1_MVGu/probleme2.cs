//Problème #2  Récursivité , Effacer les taches
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
        const int SIZE = 18;
        const double POURCENTAGECELLULEGRISEE = 30; //Établi le pourcentage de taches dans le tableau. Doit être entre 0 et 99;

        const string TITLE2 = "LES TACHES";
        const string CARACTERE_TACHE = "X";
        const string CARACTERE_VIDE = "\u00B7";
        const string CARACTERE_BORDURE_HAUT_COIN_GAUCHE = " ";
        const string CARACTERE_BORDURE_HAUT = "_";
        const string CARACTERE_BORDURE_HAUT_COIN_DROIT = " ";

        const string CARACTERE_BORDURE_BAS_COIN_GAUCHE = " ";
        const string CARACTERE_BORDURE_BAS = "\u035E";
        const string CARACTERE_BORDURE_BAS_COIN_DROIT = " ";

        const string CARACTERE_BORDURE_COTE = "|";

        //Déclaration des variables
        bool[,] grid;
        Random nbrRdm;
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
            //(Ré)Initialisation
            IniGrid();

            Console.WriteLine("\nAppuyer sur une touche pour tout effacer");
            Console.ReadKey();
            for (int col = 0; col < grid.GetLength(0); col++)
            {
                for (int row = 0; row < grid.GetLength(1); row++)
                {
                    verifierTache(col,row,grid, false);
                }
            }

            ShowGrid();

        }

        private void effacerTaches(int _col, int _row, bool[,] _grid)
        {
            grid[_col, _row] = false;
        }


        //Retourne vrai si une cellule grise est à côté
        private void verifierTache(int _col, int _row, bool[,] _grid, bool pdt)
        {
            bool estUneTache = pdt;

            if(grid[_col,_row])
            {
                // Check cellule à gauche
                if (_col > 0)
                {                               // XXX
                    if (_grid[_col - 1, _row])  // O X
                    {                           // XXX 
                        effacerTaches(_col, _row, _grid);
                        verifierTache(_col - 1, _row, _grid, true);
                        estUneTache = true;
                    }
                }

                // Check cellule droite
                if (_col + 1 < grid.GetLength(1))
                {                               // XXX
                    if (_grid[_col + 1, _row])  // X O
                    {                           // XXX 
                        effacerTaches(_col, _row, _grid);
                        verifierTache(_col + 1, _row, _grid, true);
                        estUneTache = true;
                    }
                }

                // Check cellule en bas
                if (_row + 1 < grid.GetLength(0))
                {                               // XXX
                    if (_grid[_col, _row + 1])  // X X
                    {                           // XOX 
                        effacerTaches(_col, _row, _grid);
                        verifierTache(_col, _row + 1, _grid, true);
                        estUneTache = true;
                    }
                }

                // Check cellule en haut
                if (_row > 0)
                {                               // XOX
                    if (_grid[_col, _row - 1])  // X X
                    {                           // XXX 
                        effacerTaches(_col, _row, _grid);
                        verifierTache(_col, _row - 1, _grid, true);
                        estUneTache = true;
                    }
                }

                //Check diagonale haut gauche
                if (_col > 0 && _row > 0)
                {                                   // OXX
                    if (_grid[_col - 1, _row - 1])  // X X
                    {                               // XXX 
                        effacerTaches(_col, _row, _grid);
                        verifierTache(_col - 1, _row - 1, _grid, true);
                        estUneTache = true;
                    }
                }

                //Check diagonale haut droite
                if (_col > 0 && _row + 1 < grid.GetLength(1))
                {                                   // XXO
                    if (_grid[_col - 1, _row + 1])  // X X
                    {                               // XXX 
                        effacerTaches(_col, _row, _grid);
                        verifierTache(_col - 1, _row + 1, _grid, true);
                        estUneTache = true;
                    }
                }

                //Check diagonale bas gauche
                if (_col > 0 && _row + 1 < grid.GetLength(0))
                {                                   // XXX
                    if (_grid[_col - 1, _row + 1])  // X X
                    {                               // OXX 
                        effacerTaches(_col, _row, _grid);
                        verifierTache(_col - 1, _row + 1, _grid, true);
                        estUneTache = true;
                    }
                }

                //Check diagonale bas droite
                if (_col + 1 < grid.GetLength(1) && _row + 1 < grid.GetLength(0))
                {                                   // XXX
                    if (_grid[_col + 1, _row + 1])  // X X
                    {                               // XXO 
                        effacerTaches(_col, _row, _grid);
                        verifierTache(_col + 1, _row + 1, _grid, true);
                        estUneTache = true;
                    }
                }
            }
            if(estUneTache)
            {
                effacerTaches(_col, _row, _grid);
            }

        }

            
        

        //réinitialise grid avec de nouvelles cellules grises. TRUE est une cellule grise
        private void IniGrid()
        { 
            double devientTache;
            for (int col = 0; col < grid.GetLength(0); col++)
            {
                for (int row = 0; row < grid.GetLength(1); row++)
                {
                    //System.Threading.Thread.Sleep(12);        //Peut être décommenté pour donner un effet
                    devientTache = nbrRdm.Next(0, 100);
                    if(devientTache < POURCENTAGECELLULEGRISEE)
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

        //affiche le tableau avec ses données
        private void ShowGrid()
        {
            Console.WriteLine(centerText(TITLE2));
            String sCaractereAjoute = "";

            String[] LigneAffichage = new String[grid.GetLength(0)];



            Console.WriteLine("Grandeur du tableau : " + grid.GetLength(0) + " x " + grid.GetLength(1));
            Console.WriteLine("Pourcentage de cellule grisées : " + POURCENTAGECELLULEGRISEE + "%");


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
       
        //Retourne le text centré par rapport à la largeur de la fenêtre
        private string centerText(string text)
        {
            string centeredText;
            centeredText = String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text);
            return centeredText;
        }
    }
}
