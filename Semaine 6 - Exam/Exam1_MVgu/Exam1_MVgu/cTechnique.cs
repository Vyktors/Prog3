using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1_MVgu
{
    class cTechnique : cTechnicien
    {
        public cTechnique()
        {
            Nom = "Inconnu";
            Prenom = "Inconnu";
            Poste = "Poste inconnu";
            Salaire = 0;
            NumEmp = 0;
        }
        public cTechnique(string nom, string prenom, string poste, int salaire, int numEmp)
        {
            Nom = nom;
            Prenom = prenom;
            Poste = poste;
            Salaire = salaire;
            NumEmp = numEmp;

        }
        public override void InstallLog()
        {
            Console.WriteLine("Je fais l'installation de logiciel comme un technicien réseau");
        }

        public override void Entretien()
        {
            Console.WriteLine("Je fais l'entretien du réseau comme un technicien réseau");
        }
    }
}
