using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Mod4Sect8
{
    class Stats
    {
        public void Start()
        {
            Lab1Mod4Sect8.Posted += HasPosted;
        }
        void HasPosted()
        {
            Console.WriteLine("Survey Posted, Start");
        }
    }
}
