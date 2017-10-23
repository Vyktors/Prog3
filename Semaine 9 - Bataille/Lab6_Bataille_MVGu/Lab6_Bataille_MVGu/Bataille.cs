using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Bataille_MVGu
{
    class Bataille
    {
        public Bataille()
        {
            Pile pile1 = new Pile(5);
            Carte carteaAjouter;

            for (int i = 0; i < pile1.TailleMax(); i++)
            {
                carteaAjouter = new Carte();
                pile1.Empiler(carteaAjouter);
            }

        }        

    }
}
