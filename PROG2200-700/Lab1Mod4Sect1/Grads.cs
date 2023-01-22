using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Mod4Sect7
{
    internal class Grads : Member, IGraduate
    {
        public void Graduate()
        {
            Console.WriteLine("Student has graduated!");
        }
    }
}