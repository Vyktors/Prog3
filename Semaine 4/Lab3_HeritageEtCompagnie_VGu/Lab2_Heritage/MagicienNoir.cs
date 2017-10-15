using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_HeritageEtCompagnie
{
    class MagicienNoir:Magicien
    {
        public MagicienNoir(string _nom, int _pv) : base(_nom, _pv)
        {
            pm = 4;
            //Console.WriteLine("un magicien noir");
        }

        public void Attaquer(Personnage cible)
        {
            if (!(cible is MagicienNoir))
            {
                //Console.WriteLine("Je suis " + nom + " et j'attaque " + cible.Nom);
                infligerDegats(cible, baguette.Dmg);
            }
            else
            {
                //Console.WriteLine("Impossible d'Attaquer la cible");
            }
        }
    }
}
