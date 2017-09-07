using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_HeritageEtCompagnie
{
    class Jeu
    {
        public Jeu()
        {
            MagicienNoir magN = new MagicienNoir("Bob", 100);
            MagicienBlanc magB = new MagicienBlanc("Magicien Blanc", 100);
            Guerrier guer1 = new Guerrier("Guerrier 1 Bob", 100);
            Guerrier guer2 = new Guerrier("Guerrier 2 Jacques", 100);


            //Actions
            magN.Attaquer(guer1);

            guer1.Attaquer(magN);

            magB.soigner(magN);

            magB.soigner(guer1);
        }
    }
}
