namespace Les11.Models
{
    public class Verkoop
    {

        public DateTime DatumVerkoop { get; set; }

        public double TotaalSaldo
        {
            get
            {
                double totaal = Producten.Select(x => x.Prijs).Sum();

                return totaal;
            }
        }

        public double VervoersKosten { get; set; }

        public List<Product> Producten { get; set; }

        public Verkoop()
        {
            DatumVerkoop = DateTime.Now;
            Producten = new List<Product>();
            VervoersKosten = 25;
        }

        public void ProductToevoegen(Product product)
        {
            Producten.Add(product);
        }

        public void ProductVerwijderen(Product product)
        {
            Producten.Remove(product);
        }

        public double VerkoopAfronden()
        {
            if (TotaalSaldo >= 1000)
            {
                return Math.Round(TotaalSaldo, 2);
            }
            else
            {
                double resultaat = TotaalSaldo + VervoersKosten;
                return Math.Round(resultaat, 2);
            }
        }
    }
}
