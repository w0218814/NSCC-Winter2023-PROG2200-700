using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Mod4Sect7
{
    internal class Principal : Member, IPayee
    {
        public void Pay()
        {
            Console.WriteLine("Paying the Principal from the Principal Class");
        }
    }
}
