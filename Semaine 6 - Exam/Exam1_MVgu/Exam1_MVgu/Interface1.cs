using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1_MVgu
{
    interface iInformaticien
    {

        string Nom { get; set; }
        string Prenom { get; set; }
        string Poste { get; set; }
        int Salaire { get; set; }
        int NumEmp { get; set; }

        void diriger();
        void proger();
        void analyser();
        void support();
        void InstallLog();
        void Entretien();
        
    }

    
}
