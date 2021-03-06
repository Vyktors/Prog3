﻿//Problème #1  Récursivité , Les huits reines

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
            Console.Clear();
            //   Parcourir les colonnes du damier
            for (int i = 0; i < SIZE; i++)
            {
                if (Place_Reine_Securite(1, i, 0, grid))
                {
                    Console.WriteLine("Colonne " + i + " a au moins une solution");
                }

                else
                {
                    Console.WriteLine("Colonne " + i + " n'a pas de solution");
                }
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

                if (_ligne + 1 >= SIZE)
                {
                    // Je suis en sécurité sur la dernière ligne de la colonne alors solution viable  
                    CptBonneSolution++;
                    Imprime_Solution(_NoSln, _grid);
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
                    // Retour faux
                    _grid[_col, 0] = 0;
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

        private bool Imprime_Solution(int _NoSln, int[,] _grid)
        {

            Console.WriteLine("Solution " + _NoSln + "  Cumulatif: " + CptBonneSolution);
            
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
