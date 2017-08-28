//Semaine 1
//Laboratoire #1 - INTRO À LA POO

using System;

namespace Lab_01_IntroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Cpoint1 point1 = new Cpoint1(1, 2);
            Cpoint2 point2 = new Cpoint2(2, 4);
            Cpoint3 point3 = new Cpoint3(10, 5);
            Cpoint4 point4 = new Cpoint4(20, 10);
            
            //Exercice 1
            Console.WriteLine("Exercice 1");
            point1.affiche();
            point1.deplace(3, 4);    
            point1.affiche();
            Console.WriteLine();


            //Exercice 2
            Console.WriteLine("Exercice 2");
            Console.WriteLine("Coordonnee: " + point2.abscisse() + ", " + point2.ordonnee());
            point2.deplace(4, 5);
            Console.WriteLine("Coordonnee: " + point2.abscisse() + ", " + point2.ordonnee());
            Console.WriteLine();

            //Exercice 3
            Console.WriteLine("Exercice 3");
            point3.affiche();
            point3.deplace(3, 4);
            point3.affiche();
            
            Console.ReadLine();

            //Exercice 4
            //Dans l'ideal, fusionner la fonction déplacer et afficher afin d'optimiser le code.
            Console.Clear();
            Console.WriteLine("Exercice 4");
            point4.affiche();
            Console.ReadLine();

            point4.deplace(3, 4);
            point4.affiche();
            Console.ReadLine();

            point4.deplace(10, 15);
            point4.affiche();
            Console.ReadLine();

            point4.deplace(25, 0);
            point4.affiche();
            Console.ReadLine();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}