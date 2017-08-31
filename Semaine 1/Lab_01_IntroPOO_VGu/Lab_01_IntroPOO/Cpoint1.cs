using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_01_IntroPOO
{
    class Cpoint1
    {
        private double positionX;
        private double positionY;

        public Cpoint1(double posX, double posY)
        {
            positionX = posX;
            positionY = posY;
        }

        public void deplace(double depX, double depY)
        {
            Console.WriteLine("Deplacement de " + depX + " en X et de " + depY + " en Y..");
            positionX += depX;
            positionY += depY;
        }

        public void affiche()
        {
            Console.WriteLine("Coordonnees: " + positionX + ", " + positionY);
        }
    }
}
