using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_recursivite_1_MVGu
{
    class Program
    {
        static void Main(string[] args)
        {
            
            probleme1 probleme1 = new probleme1();
            probleme2 probleme2 = new probleme2();
            probleme3 probleme3 = new probleme3();
            int choix = new int();            

            Console.WriteLine("Quel probleme voulez vous tester? : ");
            Console.WriteLine("     1 : Problème #1 , Les huit reines");
            Console.WriteLine("     2 : Problème #2 , Effacer une tache");
            Console.WriteLine("     3 : Problème #3 , Les tours de Hanoï");

            do
            {
                try
                {
                    Console.Write("Choix: ");
                    choix = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Veuillez entrer un nombre valide");
                }

            } while (choix == 0 || choix > 3);

            Console.Clear();

            switch(choix)
            {
                case 1:
                    probleme1.Start();
                    break;
                case 2:
                    //probleme2.Start();
                    break;
                case 3:
                    //probleme3.Start();
                    break;
            }

            Console.WriteLine("\nTouchez une touche pour terminer le programme");
            Console.ReadKey();
        }





    }
}
