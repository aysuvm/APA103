using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_UpcastingDowncastingExplicitImplicit
{
    internal class Manatcs
    {
        public decimal AZN { get; set; }
        public Manatcs(decimal manat)
        {
            AZN = azn;
        }
            public static implicit operator Manatcs(Dollar dollar)
        {
            return new Manatcs(dollar.USD * 1.70m);
        }
    }
}
