using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Bataille_MVGu
{
    class Bataille
    {
        Random nbrRdm = new Random();
        Pile pileIni;
        Pile pileJ1;
        Pile pileJ2;
        Pile pileGainJ1;
        Pile pileGainJ2;
        int mancheGJ1;
        int mancheGJ2;
        Carte T1;
        Carte T2;
        int ptsJ1;
        int ptsJ2;
        int nbrCarteJoueurMax;
        

        const string TITLE = "LABORATOIRE 6 : BATAILLE";
        const string PROGRAMEUR = "Victor Guérin";

        public Bataille()
        {
            mancheGJ1 = 0;
            mancheGJ2 = 0;
            ptsJ1 = 0;
            ptsJ2 = 0;

            setWindow();
            showTitle();

            Console.WriteLine("Combien de carte voulez vous par joueur ?");

            //Demande au joueur le nbr de carte par joueur;
            bool err;
            do
            {                
                try
                {
                    err = false;
                    Console.Write("Nombre de carte par joueur : ");
                    nbrCarteJoueurMax = Convert.ToInt32(Console.ReadLine());  
                    if(nbrCarteJoueurMax > 50 || nbrCarteJoueurMax <= 0)
                    {
                        Console.WriteLine("Entrez un nombre entre 1 et 50 \n");
                        
                    }
                }
                catch
                {
                    Console.WriteLine("Entrez un nombre!\n");
                    err = true;
                }
            }while (err || nbrCarteJoueurMax > 50 || nbrCarteJoueurMax <= 0) ;
                                    
            //Création du premier packet de 100;
            creerIniCartes();
            pileJ1 = new Pile(nbrCarteJoueurMax);
            pileJ2 = new Pile(nbrCarteJoueurMax);
            pileGainJ1 = new Pile(nbrCarteJoueurMax * 2);
            pileGainJ2 = new Pile(nbrCarteJoueurMax * 2);

            attribuerCarte(nbrCarteJoueurMax);

            Console.WriteLine(centerText("LA PARTIE COMMENCE!"));

            //Joue tous les tours
            for (int i = 0; i < nbrCarteJoueurMax; i++)
            {
                T1 = pileJ1.Depiler();
                T2 = pileJ2.Depiler();

                Console.Write("Tour " + (i + 1) + " : ");
                if (T1.Valeur == T2.Valeur)
                {
                    if (T1.Couleur == T2.Couleur)
                    {
                        pileGainJ1.Empiler(T1);
                        pileGainJ2.Empiler(T2);
                        Console.WriteLine("Chacun conserve leur carte");
                    }
                    else if (T1.Couleur > T2.Couleur)
                    {
                        Joueur1Gagne();
                    }
                    else
                    {
                        Joueur2Gagne();
                    }
                }
                else if (T1.Valeur > T2.Valeur)
                {
                    Joueur1Gagne();
                }
                else
                {
                    Joueur2Gagne();
                }                
            }

            Console.WriteLine(centerText("Toutes les cartes ont été jouées!\n"));
            Console.WriteLine(centerText("RÉSULTATS"));
            //Compter les points

            ptsJ1 = Convert.ToInt32(compterPoints(pileGainJ1));
            ptsJ2 = Convert.ToInt32(compterPoints(pileGainJ2));
            Console.WriteLine("Joueur 1 : " + ptsJ1 + " points avec " + mancheGJ1 + " manches gagnées");
            Console.WriteLine("Joueur 2 : " + ptsJ2 + " points avec " + mancheGJ2 + " manches gagnées");

        }
        private double compterPoints(Pile _pile)
        {
            double pts = 0;
            Carte X;
            while(!(_pile.PileVide()))
            {
                X = _pile.Depiler();
                if(X.Couleur == 1)
                {
                    pts += (X.Valeur * 1.5 * X.Bonus);
                }
                else
                {
                    pts += (X.Valeur * X.Bonus);
                }                
            }
            return pts;
        }

        private void Joueur1Gagne()
        {
            pileGainJ1.Empiler(T1);
            pileGainJ1.Empiler(T2);
            Console.WriteLine("Joueur 1 Gagne!");
            mancheGJ1++;
        }

        private void Joueur2Gagne()
        {
            pileGainJ2.Empiler(T1);
            pileGainJ2.Empiler(T2);
            Console.WriteLine("Joueur 2 Gagne!");
            mancheGJ2++;
        }
        private void attribuerCarte(int _nbrCarteJoueur)
        {
            for (int i = 0; i < _nbrCarteJoueur; i++)
            {
                pileJ1.Empiler(pileIni.Depiler());
                pileJ2.Empiler(pileIni.Depiler());
            }
        }

        private void showTitle()
        {
            Console.Clear();
            Console.WriteLine(centerText("**" + TITLE + "**"));
            Console.WriteLine(centerText("Par : " + PROGRAMEUR));
            Console.WriteLine();
            
        }

        private void setWindow()
        {
            Console.SetWindowSize(120, 40);                         //Défini la grandeur de la fenêtre
            Console.Title = TITLE + " - " + PROGRAMEUR;             //Défini le titre de la fenêtre
            Console.BackgroundColor = ConsoleColor.Gray;            //Défini la couleur de l'arrière-plan
            Console.ForegroundColor = ConsoleColor.Black;           //Défini la couleur de la police
            Console.OutputEncoding = System.Text.Encoding.UTF8;     //Utilisé pour pouvoir afficher symboles particuliers (ex: bordures dans probleme #1)
        }

        //Retourne le text centré par rapport à la largeur de la fenêtre
        private string centerText(string text)
        {
            string centeredText;
            centeredText = String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text);
            return centeredText;
        }

        //Fait la création de 100 nouvelles cartes et les ajoutes à un packet
        private void creerIniCartes()
        {
            pileIni = new Pile(100);
            Carte nvCarte;
            for (int i = 0; i < 100; i++)
            {
                nvCarte = new Carte(genValeur(), genBonus(), genCouleur());
                pileIni.Empiler(nvCarte);
            }
            
        }

        //Génère une valeur aléatoire entre 1 et 10
        private int genValeur()
        {
            return nbrRdm.Next(1, 11);
        }

        //Génère une valeur aléatoire entre 1 et 4
        private int genBonus()
        {
            return nbrRdm.Next(1, 5);
        }

        //Génère une valeur aléatoire entre 0 et 1
        private int genCouleur()
        {
            return nbrRdm.Next(0, 2);
        }




        
    }
}
