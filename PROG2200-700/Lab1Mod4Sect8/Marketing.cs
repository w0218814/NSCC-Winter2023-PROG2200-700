using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Mod4Sect8
{
    class Marketing
    {
        public void End()
        {
            Lab1Mod4Sect8.Posted += HasPosted;
        }
        void HasPosted()
        {
            Console.Write("\nPosted and ended\n");
        }
    }
}
