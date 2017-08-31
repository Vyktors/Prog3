using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_HeritageEtCompagnie
{
    class Magicien:Personnage
    {
        public Magicien(string _nom, int _pv): base(_nom, _pv)
        {
            baguette = new Baguette("bouchou", 20, "Rouge"); 
        }

        //Variables
        protected Baguette baguette;

    }
}
