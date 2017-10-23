using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Bataille_MVGu
{
    class Carte
    {
        private Carte carteSuivante = null;
        private int valeur = 0;
        private int bonus = 0;
        private bool couleur = false;

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

        public bool Couleur
        {
            get { return couleur; }
            set { couleur = value; }
        }
    }
}
