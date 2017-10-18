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
            
            int choix;
            string title = "LABORATOIRE 5 : RÉCURSIVITÉ";
            string programmeur = "Victor Guérin";

            //Set les paramètres de base
            setWindow();

            do
            {
                showMenu();

                Console.WriteLine("\nProgramme terminé.");
                Console.WriteLine("Touchez une touche pour revenir au menu");
                Console.ReadKey();
            } while (true);



            //Retourne le text centré par rapport à la largeur de la fenêtre
            string centerText(string text)
            {
                string centeredText;
                centeredText = String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text);
                return centeredText;
            }
            //Set les paramètres de base
            void setWindow()
            {
                Console.SetWindowSize(120, 40);                         //Défini la grandeur de la fenêtre
                Console.Title = title + " - " + programmeur;            //Défini le titre de la fenêtre
                Console.BackgroundColor = ConsoleColor.Gray;            //Défini la couleur de l'arrière-plan
                Console.ForegroundColor = ConsoleColor.Black;           //Défini la couleur de la police
                Console.OutputEncoding = System.Text.Encoding.UTF8;     //Utilisé pour pouvoir afficher symboles particuliers (ex: bordures dans probleme #1)
            }

            void showMenu()
            {
                Console.Clear();
                Console.WriteLine(centerText("**" + title + "**"));
                Console.WriteLine(centerText("Par : " + programmeur));
                Console.WriteLine();
                Console.WriteLine("Quel problème de récursivité voulez vous tester? : ");
                Console.WriteLine("     1 : Problème #1 , Les huit reines");
                Console.WriteLine("     2 : Problème #2 , Effacer une tache");
                Console.WriteLine("     3 : Problème #3 , Les tours de Hanoï");
                Console.WriteLine("     4 : Sortir du programme");

                do
                {
                    //Gère si l'utilisateur entre un charactère qui n'est pas un chiffre
                    choix = 0;
                    try
                    {
                        Console.Write("\nChoix: ");
                        choix = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Veuillez entrer un nombre valide!");
                    }
                    //Gère si l'utilisateur entre un charactère qui ne se trouve pas entre 1 et 4
                    if (choix == 0 || choix > 4)
                    {
                        Console.WriteLine("Veuillez entrer un nombre entre 1 et 4!");
                    }
                } while (choix == 0 || choix > 4);

                Console.Clear();

                switch (choix)
                {
                    case 1:
                        probleme1.Start();
                        break;
                    case 2:
                        probleme2.Start();
                        break;
                    case 3:
                        probleme3.Start();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }

        }
        





    }
}
