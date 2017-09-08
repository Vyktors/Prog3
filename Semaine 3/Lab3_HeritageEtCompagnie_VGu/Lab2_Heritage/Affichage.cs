using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_HeritageEtCompagnie
{
    class Affichage
    {
        private const int width = 20; //Doit être un multiple de deux, défini la largeur des cases Entre 2-20


        private int rows;
        private int cols;

        private Cellule[,] grid;

        public Affichage()
        {
            rows = (int)(Console.WindowHeight / (width / 2));
            cols = (int)(Console.WindowWidth / width);
            grid = new Cellule[cols, rows];

            
            iniGrille();
            afficherGrille();
            Console.SetWindowPosition(0, 0);
        }

        public void iniGrille()
        {
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Cellule cell = new Cellule(i, j, width);
                    grid[i, j] = cell;
                }
            }
        }
        public void afficherGrille()
        {
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    grid[i, j].show();
                }
            }

        }
    }
}
