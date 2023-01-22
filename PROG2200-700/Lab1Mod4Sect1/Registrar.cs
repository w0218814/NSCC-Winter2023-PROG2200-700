using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Mod4Sect7
{
    interface IGraduate
    {
        void Graduate();
    }
    internal class Registrar : Member
    {

        List<IGraduate> grads = new List<IGraduate>();

        public Registrar()
        {
            grads.Add(new Grads());
        }

        public void GraduateAll()
        {
            foreach (IGraduate graduate in grads)
            {
                Console.WriteLine("Another student has graduated!");
            }
        }
    }
}
    