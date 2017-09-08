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
        Personnage perso;

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
            if(x % 2 == 0){
                if(y%2 == 0){
                    Console.BackgroundColor = ConsoleColor.Gray;
                }
                else {
                    Console.BackgroundColor = ConsoleColor.White;
                }             
            }
            else{
                if (y % 2 == 1){
                    Console.BackgroundColor = ConsoleColor.Gray;
                }
                else{
                    Console.BackgroundColor = ConsoleColor.White;
                }
            }                                  

            for(int j = 0; j < width /2; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    Console.SetCursorPosition((x * width) + i, (y*width/2)+j);
                    Console.Write(" ");
                }
            }
            
        }
    }
}
