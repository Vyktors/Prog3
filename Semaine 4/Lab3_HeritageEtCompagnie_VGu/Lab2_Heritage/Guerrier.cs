using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_HeritageEtCompagnie
{
    class Guerrier : Personnage 
    {
        //Variable
        private Epee epee;
        

        public Guerrier(string _nom, int _pv) : base(_nom,_pv)
        {
            pm = 4;
            //Console.WriteLine("un guerrier");
            epee = new Epee("Escalibur");
        }
        

        public void Attaquer(Personnage cible) 
        {
            if(cible is MagicienNoir)
            {
                //Console.WriteLine("Je suis " + nom + " et je frappe " + cible.Nom + " comme un cretin ");

                if(infligerDegats(cible, epee.Dmg)) //Si élimine qqun
                {
                    this.epee.lvlUp();
                }

            }
            else
            {
                //Console.WriteLine("Impossible d'Attaquer la cible");
            }
            
        }

        


    }
}
