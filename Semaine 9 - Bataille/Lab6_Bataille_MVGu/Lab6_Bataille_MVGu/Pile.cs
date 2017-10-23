using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Bataille_MVGu
{
    class Pile
    {
        private Carte ancre;
        private int tailleMax;
        private int cpt_carte;

        public Pile(int _tailleMax)
        {
            ancre = null;
            tailleMax = _tailleMax;
            cpt_carte = 0;
        }

        public void Empiler(Carte carte)
        {
            //Si le nbr de cartes de ma pile est rendu à son maximum
            if(cpt_carte == tailleMax)
            {
                Console.WriteLine("Taille maximale de la pile atteinte, impossible d'ajouter un élément");
            }
        }
    }
}
