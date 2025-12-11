using Les11.Models;

namespace Les11.Testing
{
    internal class VerkoopTests
    {
        [Test]
        public void Verkoop_TotaalSaldo_IsGelijkAan_SomVanAlleProductenBinnenVerkoop()
        {
            //Arrange
            Product nintendoSwitch = new Product
            {
                Naam = "Nintendo Switch",
                Prijs = 250
            };

            Product smartFridge = new Product
            {
                Naam = "Samsung Smart Fridge",
                Prijs = 1499.99
            };

            Product voetbal = new Product()
            {
                Naam = "Heel erg ronde bal",
                Prijs = 14.75
            };

            Verkoop verkoop = new Verkoop();
            verkoop.ProductToevoegen(nintendoSwitch);
            verkoop.ProductToevoegen(smartFridge);
            verkoop.ProductToevoegen(voetbal);

            double verwachtResultaat = 1764.74;

            // Act
            double resultaat = verkoop.TotaalSaldo;

            // Assert
            Assert.That(verwachtResultaat, Is.EqualTo(resultaat));
        }

        [Test]
        public void VerkoopAfgerond_BerekentSubTotaalPlusVerzending()
        {
            //Arrange
            Product nintendoSwitch = new Product
            {
                Naam = "Nintendo Switch",
                Prijs = 250
            };

            Product voetbal = new Product()
            {
                Naam = "Heel erg ronde bal",
                Prijs = 14.75
            };

            Verkoop verkoop = new Verkoop();
            verkoop.ProductToevoegen(nintendoSwitch);
            verkoop.ProductToevoegen(voetbal);

            double verwachtResultaat = 289.75;

            // Act
            double resultaat = verkoop.VerkoopAfronden();

            // Assert
            Assert.That(verwachtResultaat, Is.EqualTo(resultaat));
        }

        [Test]
        public void VerkoopAfgerond_VerkoopBoven1000Euro_KrijgtGratisVerzending()
        {
            //Arrange
            Product nintendoSwitch = new Product
            {
                Naam = "Nintendo Switch",
                Prijs = 250
            };

            Product smartFridge = new Product
            {
                Naam = "Samsung Smart Fridge",
                Prijs = 1499.99
            };

            Product voetbal = new Product()
            {
                Naam = "Heel erg ronde bal",
                Prijs = 14.75
            };

            Verkoop verkoop = new Verkoop();
            verkoop.ProductToevoegen(nintendoSwitch);
            verkoop.ProductToevoegen(smartFridge);
            verkoop.ProductToevoegen(voetbal);

            double verwachtResultaat = 1764.74;

            // Act
            double resultaat = verkoop.VerkoopAfronden();

            // Assert
            Assert.That(verwachtResultaat, Is.EqualTo(resultaat));
        }
    }
}
