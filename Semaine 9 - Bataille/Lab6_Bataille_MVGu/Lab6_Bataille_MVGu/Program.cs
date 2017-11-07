//Laboratoire #6 : Bataille
//Le programme consiste à instancier un paquet de carte , de le distribuer à tour de rôle à deux joueurs, puis,
//chaque joueur tourne une carte à chaque tour, celui qui obtient la valeur la plus haute(rouge > noire en cas
//d'égalité gagne les deux cartes et les rajoutes à sa pile de gain. Le joueur qui à le plus de point obtient
//la victoire.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Bataille_MVGu
{
    class Program
    {
        static void Main(string[] args)
        {


            Bataille bataille = new Bataille();
            Console.ReadKey();

            
        }

        
    }
}
