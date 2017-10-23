using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1_MVgu
{
    class cAnalyste : iInformaticien
    {
        public cAnalyste()
        {
            Nom = "Inconnu";
            Prenom = "Inconnu";
            Poste = "Poste inconnu";
            Salaire = 0;
            NumEmp = 0;
        }
        public cAnalyste(string nom, string prenom, string poste, int salaire, int numEmp)
        {
            Nom = nom;
            Prenom = prenom;
            Poste = poste;
            Salaire = salaire;
            NumEmp = numEmp;

        }

        public void diriger()
        {
            Console.WriteLine("Je dirige des camarades");
        }

        public void proger()
        {
            Console.WriteLine("Je programme des applications");
        }

        public void analyser()
        {
            Console.WriteLine("J'analyse");
        }

        public void support()
        {
            Console.WriteLine("fait du soutien aux usagers");
        }

        public void InstallLog()
        {
            Console.WriteLine("J'installe des logiciels");
        }

        public void Entretien()
        {
            Console.WriteLine("Je fais l'entretien des réseaux");
        }

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Poste { get; set; }
        public int Salaire { get; set; }
        public int NumEmp { get; set; }
    }
}
