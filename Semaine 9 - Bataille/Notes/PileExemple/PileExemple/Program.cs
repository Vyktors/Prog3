using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PileExemple
{
    class Program
    {
        static void Main(string[] args)
        {
            Pile pile1 = new Pile(1);
            Pile pile2 = new Pile(3);

            pile1.Empiler(34);
            pile2.Empiler(2);
            pile2.Empiler(45);
            pile1.Empiler(23);

            Console.WriteLine("La pile1 contient " + pile1.Taille_Pile() + " élément(s).");
            Console.WriteLine("La pile2 contient " + pile2.Taille_Pile() + " élément(s).");

            pile1.Depiler();
            pile2.Depiler();
            pile1.Depiler();

            Console.WriteLine("La pile1 contient " + pile1.Taille_Pile() + " élément(s).");
            Console.WriteLine("La pile2 contient " + pile2.Taille_Pile() + " élément(s).");

            Console.ReadLine();
        }
    }
}
