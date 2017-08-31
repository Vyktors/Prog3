using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_Heritage
{
    class Guerrier : Personnage 
    {
        public Guerrier(string _nom, int _pv) : base(_nom,_pv)
        {
            Console.WriteLine("un guerrier");
        }

        public void TuerCommeUnCretinAvecUNeEpee(Personnage cible)
        {
            Console.WriteLine("Je suis " + nom + " et je frappe "+ cible.nomPerso()+ " comme un cretin ");
            infligerDegats(cible, 35);
        }


    }
}
