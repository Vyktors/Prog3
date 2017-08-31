using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_HeritageEtCompagnie
{
    class Baguette:Arme
    {
        public Baguette(string _nom, int _dmg, string _couleur) : base(_nom, _dmg)
        {
            couleur = _couleur;
        }

        private string couleur;

        
    }
}
