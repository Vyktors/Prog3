using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_Heritage
{
    class Personnage
    {
        public Personnage(string _nom, int _pv)
        {
            nom = _nom;
            pv = _pv;
            Console.Write("Je m'appelle " + _nom + " et je suis ");
        }

        protected string nom; //Nom du personnage
        protected int pv;     //Points de vie


        private void recevoirDegats(int degats)
        {
            pv -= degats;
            Console.WriteLine(nom + " : " + pv + "pv restants");
            Console.WriteLine();
        }

        protected void infligerDegats(Personnage cible, int dgts)
        {
            cible.recevoirDegats(dgts);
        }

        public string nomPerso()
        {
            return nom;
        }
    }
}
