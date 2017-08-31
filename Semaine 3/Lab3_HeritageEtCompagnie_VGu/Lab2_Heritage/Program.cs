using System;

namespace Lab3_HeritageEtCompagnie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables

            MagicienNoir magN = new MagicienNoir("Robert", 100);
            MagicienBlanc magB = new MagicienBlanc("Gandalf", 100);
            Guerrier guer1 = new Guerrier("Bob", 100);
            Guerrier guer2 = new Guerrier("Jacques", 100);


            //Actions
            guer1.Attaquer(magN);

            magB.soigner(magN);
            Console.ReadLine();
        }
    }
}
