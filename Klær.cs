using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringsystem
{
    internal class Klær : IProdukt
    {
        public string Navn { get; set; }
        public double Pris { get; set; }
        public string Størrelse { get; set; }
        public void SkrivUtInfo()
        {

            Console.WriteLine($"Klær: {Navn}, Pris: {Pris}, Størrelse: {Størrelse}");
        }
    

      
       

        public Klær(string navn, double pris, string størrelse)
        {
            Navn = navn;
            Pris = pris;
            Størrelse = størrelse;
        }
    }
}
