using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PileExemple
{
    class Noeud
    {
        private Noeud _suivant = null;
        private object _donnees = null;
        public Noeud Suivant
        {
            get { return _suivant; }
            set { _suivant = value; }
        }
        public object Donnees
        {
            get { return _donnees; }
            set { _donnees = value; }
        }
    }
}
