//Problème #1  Récursivité , Les huits reines

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_recursivite_1_MVGu
{
    class probleme1
    {
        const int SIZE = 8;
        int[,] grid;

        int CptBonneSolution;

        public probleme1()
        {
            CptBonneSolution = 0;
            grid = new int[SIZE, SIZE];
        }

        public void Start()
        {
            Console.Clear();
         
            Place_Reine_Securite(1, 0, 0, grid);
        }


        /* Place_Reine_Securité
             Place une reine en sécurité et retourne VRAI
             Sinon passe à la prochaine ligne de la colonne
             Si à la limite du nombre de ligne de la colonne alors pas de solution retourne FAUX 

             Si les enfants retournent VRAI alors MEMORISE LA SOLUTION et passe à la prochaine ligne
        */
        private bool Place_Reine_Securite(int _NoSln, int _col, int _ligne, int[,] _grid)
        {          
            if (_col >= SIZE || _ligne >= SIZE)
            {
                // Sortie du tableau alors considère la solution fausse et l'appel en erreur
                Console.WriteLine("Indice hors tableau avec solution no: " + _NoSln);
                return false;
            }

            /*
             * Si Position en sécurité vérifie les enfants de cette solution et passe à la prochaine colonne
             * sinon Si dernière ligne alors pas de solution retourne FAUX
             *      sinon Test la prochaine ligne
             *      
             */
            

            if (Chk_Securite_Colonne(_NoSln, _col, _ligne, _grid)
                && Chk_Securite_Ligne(_NoSln, _col, _ligne, _grid) 
                && Chk_Securite_Diagonale(_NoSln, _col, _ligne, _grid))
            {
                //  En situation sécuritaire, donc on présume solution viable jusqu'à preuve du contraire
                _grid[_col, _ligne] = _NoSln;

                if (_col + 1 >= SIZE)
                {
                    // Je suis en sécurité sur la dernière ligne de la colonne alors solution viable  
                    CptBonneSolution++;
                    Imprime_Solution(_NoSln, _grid);

                    //retourne à l'état comme si ce n'était pas une bonne solution (ce l'est) pour trouver d'autres solutions
                    _grid[_col, _ligne] = 0;

                    //continu quand même à chercher d'autre solutions
                    if (_ligne + 1 >= SIZE)
                    {
                        // Fin de la colonne pas d'autre solution
                        return false;
                    }

                    // La solution est bonne,mais on check la prochaine ligne pour d'autre solutions
                    else if (Place_Reine_Securite(_NoSln, _col, _ligne + 1, _grid))
                    {
                        // Implique que tous les enfants sont vrais donc la solution est vrai

                        return true;

                    }
                    else
                    {
                        // Implique qu'il n'y pas de solution chez les enfants
                        return false;
                    }
                }
                else if(Place_Reine_Securite(_NoSln, _col + 1, 0, _grid))
                {
                    // Implique que tous les enfants sont vrais donc la solution est vrai, continu quand même à chercher d'autre solutions
                    if (_ligne + 1 >= SIZE)
                    {
                        // Fin de la colonne pas d'autre solution
                        return false;
                    }

                    // La solution est bonne,mais on check la prochaine ligne pour d'autre solutions
                    else if (Place_Reine_Securite(_NoSln, _col, _ligne + 1, _grid))
                    {
                        // Implique que tous les enfants sont vrais donc la solution est vrai

                        return true;

                    }
                    else
                    {
                        // Implique qu'il n'y pas de solution chez les enfants
                        return false;
                    }

                    

                }
                else
                {
                    // La reine n'a pas de solution possible à cette endroit
                    // Implique qu'il n'y a pas de solution dans les enfants

                    _grid[_col, _ligne] = 0;                    

                    if (_ligne + 1 >= SIZE)
                    {
                        // Fin de la colonne pas d'autre solution
                        return false;
                    }

                    //  Pas de solution possible, check la prochaine ligne
                    else if (Place_Reine_Securite(_NoSln, _col, _ligne + 1, _grid))
                    {
                        // Implique que tous les enfants sont vrais donc la solution est vrai

                        return true;

                    }
                    else
                    {
                        // Implique qu'il n'y pas de solution chez les enfants
                        return false;
                    }

                }
               
            }
            else
            {
                // La reine n'est pas en sécurité
                if (_ligne + 1 >= SIZE)
                {
                    // Fin de la colonne pas d'autre solution
                    return false;
                }
                //  Pas en sécurité, pas besoin de vérifier les enfants, passe à la prochaine ligne de la colonne
                else if(Place_Reine_Securite(_NoSln, _col,_ligne+1, _grid))

                {
                    // Implique que tous les enfants sont vrais donc la solution est vrai

                    return true;

                }
                else
                {
                    // Implique qu'il n'y pas de solution chez les enfants
                    return false;
                }
               
            }
    }

        private bool Imprime_Solution(int _NoSln, int[,] _grid)
        {
            const string CARACTERE_REINE = "X";
            const string CARACTERE_VIDE = "\u00B7";
            const string CARACTERE_BORDURE_HAUT_COIN_GAUCHE = " ";
            const string CARACTERE_BORDURE_HAUT = "_";
            const string CARACTERE_BORDURE_HAUT_COIN_DROIT = " ";

            const string CARACTERE_BORDURE_BAS_COIN_GAUCHE = " ";
            const string CARACTERE_BORDURE_BAS = "\u035E";
            const string CARACTERE_BORDURE_BAS_COIN_DROIT = " ";

            const string CARACTERE_BORDURE_COTE = "|";


            String sCaractereAjoute = "";
            String[] LigneAffichage = new String[SIZE];

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Solution racine:" + _NoSln);
            Console.WriteLine("Nombre cumulatif de solution: " + CptBonneSolution);
            
            for (int iColonne=0; iColonne < SIZE; iColonne++)
            {
                for (int iligne = 0; iligne < SIZE; iligne++)
                {
                    
                    if (_grid[iColonne, iligne] == _NoSln)
                    {
                        sCaractereAjoute = CARACTERE_REINE;
                    }
                    else
                    {
                        sCaractereAjoute = CARACTERE_VIDE;
                    };

                    LigneAffichage[iligne] = LigneAffichage[iligne] + sCaractereAjoute;
                };

                
            };

            Console.WriteLine(CARACTERE_BORDURE_HAUT_COIN_GAUCHE + repetechar(SIZE, CARACTERE_BORDURE_HAUT)+ CARACTERE_BORDURE_HAUT_COIN_DROIT);
            for (int i=0; i < SIZE; i++)
            {
                Console.WriteLine(CARACTERE_BORDURE_COTE + LigneAffichage[i]+ CARACTERE_BORDURE_COTE);
            };
            Console.WriteLine(CARACTERE_BORDURE_BAS_COIN_GAUCHE + repetechar(SIZE, CARACTERE_BORDURE_BAS) + CARACTERE_BORDURE_BAS_COIN_DROIT);
            Console.WriteLine("");

            
            return true;
        }
        private bool Chk_Securite_Ligne(int NoSln, int _col, int _ligne, int[,] _grid)
        {
            for (int i = 0; i < SIZE; i++)
            {
                if(_grid[i,_ligne] == NoSln && i != _col)
                {
                    return false;
                }
            }
           
            return true;
        }

        string repetechar(int nbrIteration, string symbole)
        {
            string text = "";

            for (int i = 0; i < nbrIteration; i++)
            {
                text += symbole;
            }
            return text;
        }



        private bool Chk_Securite_Colonne(int NoSln, int _col, int _ligne, int[,] _grid)
        {
            for (int i = 0; i < SIZE; i++)
            {

                if (_grid[_col, i] == NoSln && i != _ligne)
                {
                    return false;
                }
            }

            return true;
        }

        private bool Chk_Securite_Diagonale(int NoSln, int _col, int _ligne, int[,] _grid)
        {
            int inc;
            bool chk = true;

            //Diagonale Bas Droit 
            inc = 1;
            while (_ligne + inc < SIZE  && _col + inc < SIZE  && chk == true) 
            {
                
                if (_grid[_col+ inc,_ligne+inc] == NoSln)
                {
                    chk = false;
                }
                inc++;
            }


            //Diagonale Haut Droit
            inc = 1;
            while (_ligne - inc >= 0 && _col + inc < SIZE  && chk == true)
            {
                
                if (_grid[_col + inc, _ligne - inc] == NoSln)
                {
                    chk = false;
                }
                inc++;
            }


            //Diagonale Bas Gauche
            inc = 1;
            while (_ligne + inc < SIZE  && _col - inc >= 0 && chk == true)
            {
                
                if (_grid[_col - inc, _ligne + inc] == NoSln)
                {
                    chk = false;
                }
                inc++;
            }

            //Diagonale Haut Gauche
            inc = 1;
            while (_ligne - inc >= 0 && _col - inc >= 0 && chk == true) 
            {
                
                if (_grid[_col - inc, _ligne - inc] == NoSln)
                {
                    chk = false;
                }
                inc++;
            } 

            
            return chk;
        }
    }
}
