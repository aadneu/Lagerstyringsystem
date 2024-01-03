using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringsystem
{
    internal class Matvare : IProdukt
    {
        public string Navn { get; set; }
        public double Pris { get; set; }
        public string Utløpsdato { get; set; }
        public void SkrivUtInfo()
        {
            Console.WriteLine($"Matvare: {Navn}, Pris: {Pris}, Utløpsdato: {Utløpsdato}");
        }

     

        public Matvare(string navn, double pris, string utløpsdato)
        {
            Navn = navn;
            Pris = pris;
            Utløpsdato = utløpsdato;
        }
    }
}
