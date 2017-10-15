using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_HeritageEtCompagnie
{
    class Baguette:Arme
    {
        //Variables
        private string couleur;

        public Baguette(string _nom, string _couleur) : base(_nom)
        {
            dmg = 90;
            couleur = _couleur;
        }

        

        
    }
}
