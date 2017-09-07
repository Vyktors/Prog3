using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_HeritageEtCompagnie
{
    class Epee:Arme
    {

        //Variables
        private int longueur;
        private int lvl;

        //Constantes
        const int LVL_MAX = 5;

        public Epee(string _nom) : base( _nom)
        {
            lvl = 0;
            lvlUp();
        }

        

        public void lvlUp()
        {
            //Annule le lvlUp ci l'épée est au niveau max
            if(lvl == LVL_MAX)
            {
                return;
            }      

            //Incrementation
            lvl++;

            //Gère les dégats
            dmg = (lvl * 5) + (int)Math.Pow(2 , lvl);    // lvl1: 07  lvl2: 14  lvl3: 23  lvl4: 36  lvl5: 57

            //Gère la longueur
            if((int)(lvl * 0.67) < 1 )      // lvl1: 01  lvl2: 01  lvl3: 02  lvl4: 02  lvl5: 03
            {
                longueur = 1;
            }
            else
            {
                longueur = (int)(lvl * (2/3));
            }
            
        }

    }
}
