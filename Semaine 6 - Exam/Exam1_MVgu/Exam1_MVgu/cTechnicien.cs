using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1_MVgu
{
    abstract class cTechnicien : iInformaticien
    {
        public static int operator +(cTechnicien t, cTechnicien t2)
        {
            int s = t.Salaire + t2.Salaire;
            return s;
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

        public virtual void support()
        {
            Console.WriteLine("fait du soutien aux usagers");
        }
        
        public abstract void InstallLog();    

        public abstract void Entretien();


        public void Somme(cTechnicien t2)
        {
            int sum = this + t2;
            Console.WriteLine("L'addition des salaires de "  + this.Nom + " et de " +  t2.Nom + " est de : " + sum);
        }
        
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Poste { get; set; }        
        public int Salaire { get; set; }
        public int NumEmp { get; set; }
    }
}
