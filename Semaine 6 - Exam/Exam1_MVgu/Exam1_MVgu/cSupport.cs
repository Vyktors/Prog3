using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1_MVgu
{
    class cSupport : cTechnicien
    {
        public cSupport()
        {
            Nom = "Inconnu";
            Prenom = "Inconnu";
            Poste = "Poste inconnu";
            Salaire = 0;
            NumEmp = 0;
        }
        public cSupport(string nom, string prenom, string poste, int salaire, int numEmp)
        {
            Nom = nom;
            Prenom = prenom;
            Poste = poste;
            Salaire = salaire;
            NumEmp = numEmp;

        }
        public override void support()
        {
            Console.Write("Je suis le meilleur quand je ");
            base.support();
        }
        public override void InstallLog()
        {
            Console.WriteLine("Je fais l'installation de logiciel comme un technicien au support");
        }

        public override void Entretien()
        {
            Console.WriteLine("Je fais l'entretien du réseau comme un technicien au support");
        }
    }
}
