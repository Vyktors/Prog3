using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_HeritageEtCompagnie
{
    class Personnage
    {
        public Personnage(string _nom, int _pv)
        {
            nom = _nom;
            pv = _pv;
            
            Console.Write("Je m'appelle " + _nom + " et je suis ");

            positionX = nbrRdm.Next(0, 101);
            positionY = nbrRdm.Next(0, 101);
        }

        protected string nom; //Nom du personnage
        protected int pv;     //Points de vie
        
        protected int positionX;
        protected int positionY;

        private Random nbrRdm = new Random();

        private void recevoirDegats(int degats)
        {
            pv -= degats;
            Console.WriteLine(nom + " : " + pv + "pv restants");
            Console.WriteLine();
        }

        protected void infligerDegats(Personnage cible, int dgts)
        {
            cible.recevoirDegats(dgts);
        }

        protected void seDeplacer()
        {

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
