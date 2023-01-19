using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Mod4Sect7
{
	internal class Teacher : Member, IPayee
	{
		public string Subject;

        public void Pay()
        {
            Console.WriteLine("Paying the Teacher from the Teacher Class");
        }
    }
}