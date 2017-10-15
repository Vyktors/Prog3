using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_HeritageEtCompagnie
{
    class Jeu
    {
        public Jeu()
        {
            Affichage affichage = new Affichage();

            List<Personnage> listPerso = new List<Personnage>();
            bool endofgame = false;
          
            creerPerso();                       

            do
            {
                foreach (Personnage perso in listPerso)
                {
                    if(perso.isDead())
                    {
                        return;
                    }
                    else
                    {
                        //Se déplacer/Attaquer / or both
                        perso.jouer(listPerso);
                    }
                    
                }



            } while (!endofgame);

            
            void creerPerso()
            {
                for (int i = 0; i < 4; i++)
                {
                    Guerrier guer = new Guerrier("Bob" + i, 100);
                    listPerso.Add(guer);
                }
                for (int i = 0; i < 2; i++)
                {
                    MagicienBlanc mG = new MagicienBlanc("Gandalf" + i, 100);
                    listPerso.Add(mG);
                }
                for (int i = 0; i < 3; i++)
                {
                    MagicienNoir mN = new MagicienNoir("VolDeMort" + i, 100);
                    listPerso.Add(mN);
                }
            }
        }
    }
}
