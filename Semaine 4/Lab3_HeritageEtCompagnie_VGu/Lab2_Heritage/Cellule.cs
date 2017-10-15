using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_HeritageEtCompagnie
{
    class Cellule
    {
        private int x;
        private int y;
        private int width;
        public Personnage perso;

        public Cellule(int _x, int _y, int _w)
        {
            x = _x;
            y = _y;
            width = _w;
            perso = null;
        }

        public void show()
        {
            int start = x * width;
            //Gère la couleur pour faire un damier
            if(perso is MagicienBlanc)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
            }
            else if(perso is MagicienNoir)
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
            }
            else if(perso is Guerrier)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else
            {
                backgroundColor();
            }

            for(int j = 0; j < width /2; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    Console.SetCursorPosition((x * width) + i, (y*width/2)+j);
                    Console.Write(" ");
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void backgroundColor()
        {
            if (x % 2 == 0)
            {
                if (y % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
            }
            else
            {
                if (y % 2 == 1)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
            }
        }


    }
}
