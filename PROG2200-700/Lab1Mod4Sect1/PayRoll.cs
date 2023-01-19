using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Mod4Sect7
{
    interface IPayee
    {
        void Pay();
    }
    internal class PayRoll
    {
        Teacher teacher1 = new Teacher();
        Teacher teacher2 = new Teacher();
        Principal principal1 = new Principal();

        public void PayAll()
        {
            teacher1.Pay();
            teacher2.Pay();
            principal1.Pay();
        }
    }
}
