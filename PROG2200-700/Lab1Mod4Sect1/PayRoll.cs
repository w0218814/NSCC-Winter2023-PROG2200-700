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

        List<IPayee> payees = new List<IPayee>();
        public PayRoll()
        {
            payees.Add(new Teacher());
            payees.Add(new Teacher());
            payees.Add(new Principal());
        }

        public void PayAll()
        {
            foreach (IPayee payee in payees)
            {
                payee.Pay();
            }

        }
    }
}
    