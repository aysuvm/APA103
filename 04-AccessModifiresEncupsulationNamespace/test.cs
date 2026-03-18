using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AccessModifiresEncupsulationNamespace
{
    public  class test
    {
        public Test(string name) 
        {
            Console.WriteLine(this);
        }

        public static void Check()
        {
            Person person = new Person("");
        }
    }
}

