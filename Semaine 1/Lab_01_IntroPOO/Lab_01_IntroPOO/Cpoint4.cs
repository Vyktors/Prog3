using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_01_IntroPOO
{
    class Cpoint4
    {
        private int positionX;
        private int positionY;

        public Cpoint4(int posX, int posY)
        {
            positionX = posX;
            positionY = posY;
        }

        public void deplace(int depX, int depY)
        {            
            positionX += depX;
            positionY += depY;
        }

        public void affiche()
        {

            Console.SetCursorPosition(positionX, Console.WindowHeight - positionY);
            Console.Write("#" + "(" + positionX + ","+positionY+")");
        }
    }
}
