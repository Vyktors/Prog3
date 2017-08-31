using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_01_IntroPOO
{
    class Cpoint2
    {
        private double positionX;
        private double positionY;

        public Cpoint2(double X, double Y)
        {
            positionX = X;
            positionY = Y;
        }      

        public void deplace(double depX, double depY)
        {
            Console.WriteLine("Deplacement de " + depX + " en X et de " + depY + " en Y..");
            positionX += depX;
            positionY += depY;
        }

        public double abscisse()
        {
            return positionX;
        }

        public double ordonnee()
        {
            return positionY;
        }
    }
}
