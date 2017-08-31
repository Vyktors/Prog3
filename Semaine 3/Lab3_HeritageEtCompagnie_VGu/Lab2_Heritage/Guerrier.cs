using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_HeritageEtCompagnie
{
    class Guerrier : Personnage 
    {
        public Guerrier(string _nom, int _pv) : base(_nom,_pv)
        {
            Console.WriteLine("un guerrier");
            epee = new Epee("Escalibur", 10, 25);
        }
        //Variable

        private Epee epee; 

        public void Attaquer(Personnage cible) 
        {
            if(cible is MagicienNoir)
            {
                Console.WriteLine("Je suis " + nom + " et je frappe " + cible.Nom + " comme un cretin ");
                infligerDegats(cible, epee.Dmg);
            }
            else
            {
                Console.WriteLine("Impossible d'Attaquer la cible");
            }
            
        }

        


    }
}
