using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _09_UpcastingDowncastingExplicitImplicit
{
    internal class Dollar
    {
        public decimal USD {  get; set; }
        public Dollar(decimal usd)
        {
            USD = usd;
        }
            public  static implicit operator Dollar (Manatcs manat) {
             return new Dollar (manat.AZN /1.70m);
        }
    }
}
