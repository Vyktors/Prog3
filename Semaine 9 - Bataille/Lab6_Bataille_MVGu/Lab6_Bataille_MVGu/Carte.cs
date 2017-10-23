using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Bataille_MVGu
{
    class Carte
    {
        Random rdm = new Random();

        private Carte carteSuivante = null;
        private int valeur = 0;
        private int bonus = 0;
        private int couleur = 0;

        public Carte()
        {
            valeur = rdm.Next(1, 11);
            bonus = rdm.Next(1, 5);
            couleur = rdm.Next(0, 2);
        }

        public Carte CarteSuivante
        {
            get { return carteSuivante; }
            set { carteSuivante = value; }
        }

        public int Valeur
        {
            get { return valeur; }
            set { valeur = value; }
        }

        public int Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }

        public int Couleur
        {
            get { return couleur; }
            set { couleur = value; }
        }
    }
}
