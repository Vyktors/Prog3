using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_HeritageEtCompagnie
{
    class Arme
    {
        public Arme(string _nom, int _dmg)
        {
            dmg = _dmg;
            nom = _nom;
        }

        //Variables 
        protected string nom;
        protected int dmg;

        public int Dmg
        {
            get { return dmg; }
        }
    }
}
