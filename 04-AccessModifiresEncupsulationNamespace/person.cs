using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AccessModifiresEncupsulationNamespace
{
    internal class person
    {
        private string name;
        public string surname;

        public Person(string name)
        {
            this.name = name;
        }

        public void GetInfo()
        {
            Console.WriteLine(this.name);
        }

    }
}