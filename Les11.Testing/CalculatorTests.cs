using Les11.Models;

namespace Les11.Testing
{
    internal class CalculatorTests
    {
        [Test]
        public void NummersOptellen_GeeftDeSomTerug_VanDeInputVelden()
        {
            // Arrange
            int getal1 = 15;
            int getal2 = 7;
            int verwachteResultaat = 22;
            Calculator calc = new Calculator();

            // Act 
            int resultaat = calc.NummersOptellen(getal1, getal2);

            // Assert
            Assert.That(verwachteResultaat, Is.EqualTo(resultaat));
        }

        [Test]
        public void NummersAftrekken_GeeftHetVerschilTerug_VanDeInputVelden()
        {
            // Arrange
            int getal1 = 15;
            int getal2 = 7;
            int verwachteResultaat = 8;
            Calculator calc = new Calculator();

            // Act 
            int resultaat = calc.NummersAftrekken(getal1, getal2);

            // Assert
            Assert.That(verwachteResultaat, Is.EqualTo(resultaat));
        }

        [Test]
        public void NummersAftrekken_MagNooitMinder0Teruggeven()
        {
            // Arrange
            int getal1 = 15;
            int getal2 = 22;
            int verwachteResultaat = 0;
            Calculator calc = new Calculator();

            // Act 
            int resultaat = calc.NummersAftrekken(getal1, getal2);

            // Assert
            Assert.That(verwachteResultaat, Is.EqualTo(resultaat));
        }

        [Test]
        public void NummersVermenigVuldigen_GeeftHetProductTerug_VanDeInputVelden()
        {
            // Arrange
            int getal1 = 15;
            int getal2 = 7;
            int verwachteResultaat = 105;
            Calculator calc = new Calculator();

            // Act 
            int resultaat = calc.NummersVermenigvuldigen(getal1, getal2);

            // Assert
            Assert.That(verwachteResultaat, Is.EqualTo(resultaat));
        }

        [Test]
        public void NummersDelenGeeftHetQuotientTerug_VanDeInputVelden()
        {
            // Arrange
            int getal1 = 15;
            int getal2 = 5;
            int verwachteResultaat = 3;
            Calculator calc = new Calculator();

            // Act 
            int resultaat = calc.NummersDelen(getal1, getal2);

            // Assert
            Assert.That(verwachteResultaat, Is.EqualTo(resultaat));
        }
    }
}
