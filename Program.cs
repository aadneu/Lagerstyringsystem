namespace Lagerstyringsystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IList<IProdukt> ElListe = new List<IProdukt>()
            {
                new Elektronikk("Xbox", 4500, 12),
                new Elektronikk("Lampe", 399, 24),
                new Elektronikk("El-gitar", 2200, 36),
            };

            IList<IProdukt> KlærListe = new List<IProdukt>()
            {
                new Klær("Bukse", 399, "Large"),
                new Klær("Truse", 140, "XX-Large"),
                new Klær("Jakke", 5000, "Small"),
            };


            List<IProdukt> MatVareListe = new List<IProdukt>()
            {
                new Matvare("Banan", 5, "snart"),
                new Matvare("Melk", 29, "Snarere enn du tror"),
                new Matvare("Øl", 40, "Neste år"),
            };

            List<IProdukt> SamletListe = new List<IProdukt>();
            SamletListe.AddRange(ElListe);
            SamletListe.AddRange(KlærListe);
            SamletListe.AddRange(MatVareListe);
            


            var lager = new Lager(SamletListe);

            

            lager.ShowLager();

            lager.RemoveProduct("Xbox");
            lager.AddProduct(new Elektronikk("Playstation", 3000, 12));
            
            lager.ShowLager();


            

        }
    }
}
