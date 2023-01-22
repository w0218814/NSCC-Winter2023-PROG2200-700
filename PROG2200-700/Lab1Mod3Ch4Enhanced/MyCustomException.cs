using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab1Mod3Ch4Enhanced
{
    class MyCustomException : FormatException
    {

        public MyCustomException(string name) : base(String.Format("Invalid Student Name: {0}", name))
        {

        }
    }


}