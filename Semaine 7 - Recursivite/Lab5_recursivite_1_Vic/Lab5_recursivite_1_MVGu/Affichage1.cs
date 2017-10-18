using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_recursivite_1_MVGu
{
    class Affichage1
    {
        private const int width = 20; //Doit être un multiple de deux, défini la largeur des cases Entre 2-20


        private int rows;
        private int cols;

        public Cellule[,] grid;

        public Affichage1(int _size)
        {
            
            rows = _size;
            cols = _size;
            grid = new Cellule[cols, rows];

            Console.SetWindowSize(_size * 26, _size * 13);

            iniGrille();
            afficherGrille();

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

            Console.SetWindowPosition(0, 0);
        }
    }
}
