using System;

namespace Lab2_Heritage
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


            Console.ReadLine();

            magN.LancerBouledeFeu(guer1);

            magB.LancerBouledeGlace(guer1);

            guer1.TuerCommeUnCretinAvecUNeEpee(magB);


            Console.ReadLine();
        }
    }
}
