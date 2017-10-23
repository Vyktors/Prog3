using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PileExemple
{
    class Pile
    {
        private Noeud _ancre;
        private int _taille;
        private int _cpt_noeud;
        
        public Pile(int t)
        {
            _ancre = null;
            _taille = t;
            _cpt_noeud = 0;
        }
        public void Empiler(object valeur)
        {
            if(_taille == _cpt_noeud)
            {
                Console.WriteLine("Taille maximale de la pile atteinte. Impossible d'ajouter un élément.");
                return;
            }
            else 
            { 
                Noeud m = new Noeud();
                m.Donnees = valeur;
                m.Suivant = _ancre;
                _ancre = m;
                _cpt_noeud++;
            }
        }
        public bool PileVide()
        {
            if (_ancre == null)
            { return true; }
            else
            { return false; }
                
        }
        public void Depiler()
        {
            int d;

            if(!PileVide())
            {
                d = (int)_ancre.Donnees;
                _ancre = _ancre.Suivant;
                _cpt_noeud--;
                Console.WriteLine("La valeur de l'élément dépilé est: " + d);
            }
            else
            {
                Console.WriteLine("Impossible de dépiler un élément, la pile est vide.");
            }
        }
        public int Taille_Pile()
        {
            return _cpt_noeud;
        }

    }
}
