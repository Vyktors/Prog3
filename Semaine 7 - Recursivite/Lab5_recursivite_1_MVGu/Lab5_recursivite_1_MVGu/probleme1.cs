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
        const int SIZE = 3;
        int[,] grid;
        bool chkLigne;
        bool chkCol;
        bool chkDia;
        int CptBonneSolution;

        public probleme1()
        {
            CptBonneSolution = 0;
            grid = new int[SIZE, SIZE];
            //UnitTEST - WORKING 
            /*grid[0, 0] = 1;
            grid[0, 3] = 1;

            for (int i = 0; i < SIZE; i++)
            {
                chkCol = Chk_Securite_Colonne(1, i, i, grid);
                chkLigne = Chk_Securite_Ligne(1, i, i, grid);
                chkDia = Chk_Securite_Diagonale(1, i, i, grid);
            }
            */


        }

        public void Start()
        {
            int NoSolution;

            // Pour éviter les colisions entre les valeurs des indices du tableau et la valeur de la solution
            NoSolution = SIZE * 1000;

            //Console.Clear();

            if (Imprime_Solution(-1, grid)) { };




            //   Parcourir les colonnes du damier
            for (int i = 0; i < SIZE; i++)
            {
                NoSolution = i + SIZE * 1000;
                if (Initialise_Grille(0, grid));
                Console.WriteLine("-------------------------");

                Console.WriteLine("Solution: " + NoSolution);

                Console.WriteLine("-------------------------");
                if (Place_Reine_Securite(NoSolution, 0, i, grid))
                {
                    Console.WriteLine("Colonne " + i + " a au moins une solution");

                }

                else
                {
                    Console.WriteLine("Colonne " + i + " n'a pas de solution");
                    if (Imprime_Solution(-1, grid)) ;
                };
                Console.WriteLine("-------------------------");
            }
            

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
                // Hors tableau alors considère la solution fausse et l'appel en erreur
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

                //  En situation sécuritaire on présume la solution viable
                _grid[_col, _ligne] = _NoSln;

                if (_ligne + 1 >= SIZE || _col + 1 >= SIZE)
                {
                    /* La position est en sécurité sur la dernière ligne de la colonne ou de la dernière colonne de la ligne 
                     alors toutes la chaine de solution viable
                    */

                    CptBonneSolution++;
                    Imprime_Solution(_NoSln, _grid);
                    Console.WriteLine("Imprime tous le tableau");
                    Imprime_Solution(-1, _grid);

                    return true;
                }
                else if(Place_Reine_Securite(_NoSln, _col + 1, 0, _grid))
                {
                    // Implique que tous les enfants sont vrais donc la solution est vrai
                    // donc on imprime la solution

                    return true;

                }
                else
                {
                    // Implique qu'il n'y a pas de solution dans les enfants
                    // Efface la réponse et retourne faux à la chaine d'appel
                    _grid[_col, _ligne] = 0;
                    return false;

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

        private bool Initialise_Grille(int _Valeur, int[,] _grid)
        {

            for (int iColonne = 0; iColonne < SIZE; iColonne++)
            {
                for (int iLigne = 0; iLigne < SIZE; iLigne++)
                {
                     _grid[iColonne, iLigne]= _Valeur;
                };

            };

            return true;
        }

        private bool Imprime_Solution(int _NoSln, int[,] _grid)
        {
        

            if (_NoSln == -1)
            {
                Console.WriteLine("Imprime l'ensemble du tableau");
                for (int iColonne = 0; iColonne < SIZE; iColonne++)
                {
                    for (int iLigne = 0; iLigne < SIZE; iLigne++)
                    {
                            Console.WriteLine("Valeur : [" + iColonne + "," + iLigne + "] = " + _grid[iColonne, iLigne]);
                    };

                };
            }
            else
            {
                Console.WriteLine("Solution " + _NoSln + "  Cumulatif: " + CptBonneSolution);

                for (int iColonne = 0; iColonne < SIZE; iColonne++)
                {
                    for (int iLigne = 0; iLigne < SIZE; iLigne++)
                    {
                        if (_grid[iColonne, iLigne] == _NoSln)
                        {
                            Console.WriteLine("Reine à: [" + iColonne + "," + iLigne + "]");
                        };

                    };

                };
            };
            
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
            while (_ligne + inc < SIZE - 1 && _col + inc < SIZE - 1 && chk == true) 
            {
                
                if (_grid[_col+ inc,_ligne+inc] == NoSln)
                {
                    chk = false;
                }
                inc++;
            }


            //Diagonale Haut Droit
            inc = 1;
            while (_ligne - inc >= 0 && _col + inc < SIZE - 1 && chk == true)
            {
                
                if (_grid[_col + inc, _ligne - inc] == NoSln)
                {
                    chk = false;
                }
                inc++;
            }


            //Diagonale Bas Gauche
            inc = 1;
            while (_ligne + inc < SIZE - 1 && _col - inc >= 0 && chk == true)
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
