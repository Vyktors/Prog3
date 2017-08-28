using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_01_IntroPOO
{
    class Cpoint3
    {

        private double positionX;
        private double positionY;
        static private int cpt = 0;

        public Cpoint3(double posX, double posY)
        {
            cpt++;
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
            Console.WriteLine("Coordonnees: " + positionX + ", " + positionY + ". Nombre de point(s): = " + cpt);
        }
    }
}
