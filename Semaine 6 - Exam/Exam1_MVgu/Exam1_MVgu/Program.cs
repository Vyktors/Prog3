using System;

namespace Exam1_MVgu
{
    class Program
    {
        static void Main(string[] args)
        {
            cSupport Steve = new cSupport("Steve", "bob", "poste", 4, 2);
            cTechnique Robert = new cTechnique("Robert", "Flo", "poste", 6, 6);
            cAnalyste Jean = new cAnalyste("Jean", "Bou", "poste", 20, 1);

            Steve.support();
            Robert.Somme(Steve);
            Jean.analyser();


            

            Console.ReadLine();

            
            
        }
    }
}
