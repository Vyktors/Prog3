using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_HeritageEtCompagnie
{
    class MagicienBlanc:Magicien
    {
        //Variables

        public MagicienBlanc(string _nom, int _pv) : base(_nom, _pv)
        {
            pm = 3;
            //Console.WriteLine("un magicien blanc");
        }

        

        public void soigner(Personnage cible)
        {
            if(!(cible is MagicienNoir))
            {
                Console.WriteLine("Je suis " + nom + " et je soigne " + cible.Nom);
                infligerDegats(cible, -baguette.Dmg);
            }
            else
            {
                Console.WriteLine("Impossible de soigner la cible");
            }
            
        }

        private bool recevoirDegats(int degats)
        {
            pv = 0;
            Console.WriteLine(nom + " est mort");
            return true;
        }
    }
}
