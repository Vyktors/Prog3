using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_Heritage
{
    class Magicien:Personnage
    {
        public Magicien(string _nom, int _pv ): base(_nom, _pv)
        {

        }

        public void LancerBouledeFeu(Personnage cible)
        {
            Console.WriteLine("Je suis " + nom + " et je lance une boule de feu sur "+ cible.nomPerso());
            infligerDegats(cible, 30);
        }

        public void LancerBouledeGlace(Personnage cible)
        {
            Console.WriteLine("Je suis " + nom + " et je lance une boule de glace sur " + cible.nomPerso());
            infligerDegats(cible, 20);
        }

    }
}
