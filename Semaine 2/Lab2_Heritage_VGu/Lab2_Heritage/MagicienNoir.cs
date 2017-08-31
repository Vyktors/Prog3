using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_Heritage
{
    class MagicienNoir:Magicien
    {
        public MagicienNoir(string _nom, int _pv) : base(_nom, _pv)
        {
            Console.WriteLine("un magicien noir");
        }
    }
}
