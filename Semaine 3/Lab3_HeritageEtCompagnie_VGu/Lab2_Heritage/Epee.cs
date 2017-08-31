using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_HeritageEtCompagnie
{
    class Epee:Arme
    {
        public Epee(string _nom, int _dmg, double _longueur) : base( _nom, _dmg)
        {
            longueur = _longueur;
        }

        private double longueur;

    }
}
