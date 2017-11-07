using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Bataille_MVGu
{
    class Pile
    {
        private Carte ancre;
        private int tailleMax;
        private int cpt_carte;

        public Pile(int _tailleMax)
        {
            ancre = null;
            tailleMax = _tailleMax;
            cpt_carte = 0;
        }

        public void Empiler(Carte _carte)
        {
            //Si le nbr de cartes de ma pile est rendu à son maximum
            if(cpt_carte == tailleMax)
            {
                Console.WriteLine("Taille maximale de la pile atteinte, impossible d'ajouter un élément");
                return;
            }
            else
            {
                Carte nouvelleCarte = new Carte(_carte.Valeur, _carte.Bonus, _carte.Couleur);                                
                nouvelleCarte.CarteSuivante = ancre;
                ancre = nouvelleCarte;
                cpt_carte++; 
            }
        }


        public bool PileVide()
        {
            if(ancre == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Carte Depiler()
        {
            Carte x; //Dernière carte à avoir été retirée

            if(!PileVide())
            {
                x = ancre;
                ancre = ancre.CarteSuivante;
                cpt_carte--;
                //Console.WriteLine("La carte " + x.Valeur + " de puissance " + x.Bonus+ " a été retiré ");
                return x;
            }
            else
            {
                Console.WriteLine("La pile est vide, impossible de retirer une carte");
                return null;
            }
        }

        public int Taille_Pile()
        {
            return cpt_carte;
        }

        public int TailleMax()
        {
            return tailleMax;
        }
    }
}
