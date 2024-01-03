using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringsystem
{
    internal class Lager
    {
       public List<IProdukt> LagerProduktList { get; set; }

        public Lager()
        {
            LagerProduktList = new List<IProdukt>();
         }

        public Lager(List<IProdukt> lagerProduktList)
        {
            LagerProduktList = lagerProduktList;
        }


        public void AddProduct(IProdukt produkt)
        {
            LagerProduktList.Add(produkt);
        }

        public void RemoveProduct(string productname)
        {
            var productToRemove = LagerProduktList.FirstOrDefault(elementIListe => elementIListe.Navn == productname);
            LagerProduktList.Remove(productToRemove);
        }


        
        public void ShowLager()
        {
            
            Console.WriteLine($"Dette har du på lageret ditt");
            foreach (var vare in LagerProduktList)
            {
                vare.SkrivUtInfo();
            }
        }
        
    }
}
