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
        bool chkLigne;
        bool chkCol;
        bool chkDia;

        public probleme1()
        {

            grid = new int[SIZE,SIZE];
            //UnitTEST - WORKING 
            /*grid[0, 0] = 1;
            grid[0, 3] = 1;
            
            for (int i = 0; i < SIZE; i++)
            {
                chkCol = Chk_Securite_Colonne(1,i,i,grid);
                chkLigne = Chk_Securite_Ligne(1, i, i, grid);
                chkDia = Chk_Securite_Diagonale(1, i, i, grid);
            }
            */
              
        }

        public void Start()
        {
            Place_Reine_Securite(1, 0, 0, grid);

        }
        

        private bool Place_Reine_Securite(int _NoSln, int _col, int _ligne, int[,] _grid)
        {
            int ligneTest = _ligne;
            if(_col >= SIZE|| _ligne >= SIZE)
            {
                //2DO: Gestion d'erreur à revoir, comment arrêter le programme si erreur.
                Console.Clear();
                Console.WriteLine("ERREUR SORTI DU TABLEAU 17685");                
                return false;
            }

            while(!(Chk_Securite_Colonne(_NoSln,_col,_ligne,_grid) && Chk_Securite_Ligne(_NoSln, _col, _ligne, _grid) && Chk_Securite_Diagonale(_NoSln, _col, _ligne, _grid)))
            {
                //TANT QUE Colonne, Ligne et Diagonale sont OK.
                

            }

            _grid[_col, ligneTest] = _NoSln;



            //DEBUG
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
