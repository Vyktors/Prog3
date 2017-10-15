using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_HeritageEtCompagnie
{
    class Personnage
    {
        protected int pm;     //Points de mouvement
        protected string nom; //Nom du personnage
        protected int pv;     //Points de vie


        protected int positionX;
        protected int positionY;

        private Random nbrRdm = new Random();

        public Personnage(string _nom, int _pv)
        {
            nom = _nom;
            pv = _pv;           
            
            //Console.Write("Je m'appelle " + _nom + " et je suis ");

            positionX = nbrRdm.Next(0, 10);
            positionY = nbrRdm.Next(0, 10);
        }       

        private bool recevoirDegats(int degats)
        {
            if (degats >= pv)   //Personnage est mort
            {
                pv = 0;                
                //Console.WriteLine(nom + " est mort!");
                //Console.WriteLine();
                return true;
            }
            else
            {
                pv -= degats;
                //Console.WriteLine(nom + " : " + pv + "pv restants");
                //Console.WriteLine();
                return false;
            }                                    
        }

        protected bool infligerDegats(Personnage cible, int dgts)
        {
            if (cible.recevoirDegats(dgts))
            {
                return true;
            }
            else
                return false;
            
        }

        protected void seDeplacer()
        {
            int deplacementX;
            int deplacementY;
            int posnegY;
            do
            {
                deplacementX = nbrRdm.Next(-pm , pm + 1);
            } while (this.positionX + deplacementX < 0 || this.positionX + deplacementX > 25);

            posnegY = nbrRdm.Next(0, 2);
            if(posnegY == 0 &&  this.positionY + (pm - Math.Abs(deplacementX)) < 10)
            {
                deplacementY = pm - Math.Abs(deplacementX);
            }
            else 
            {
                deplacementY = -(pm - Math.Abs(deplacementX));
            }                        
        }

        public void jouer()
        {
            //Selectionne ses actions durant son tour.
        }
        public bool isDead()
        {
            if (this.pv == 0)
            {
                return true;
            }
            else
                return false;
        }
        //Accesseurs
        public string Nom
        {
            get {
                return nom;
            }
        }
        
        public int posX { get; set; }
        public int posY { get; set; }
        
        
    }
}
