using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_recursivite_1_MVGu
{
    class Cellule
    {
        private int x;
        private int y;
        private int width;
        public bool reine;
        

        public Cellule(int _x, int _y, int _w)
        {
            x = _x;
            y = _y;
            width = _w;
            reine = false;
        }

        public void show()
        {
            int start = x * width;
            //Gère la couleur pour faire un damier
            if (reine == true)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
            }
            
            else
            {
                backgroundColor();
            }

            for (int j = 0; j < width / 2; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    Console.SetCursorPosition((x * width) + i, (y * width / 2) + j);
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
