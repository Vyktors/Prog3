using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_HeritageEtCompagnie
{
    class Arme
    {
        //Variables 
        protected string nom;
        protected int dmg;

        public Arme(string _nom )
        {
            nom = _nom;
        }

        

        public int Dmg
        {
            get { return dmg; }
        }
    }
}
