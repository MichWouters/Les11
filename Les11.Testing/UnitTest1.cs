namespace Les11.Testing
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        public void Test1()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void VijftienPlusZeven_IsAltijd22()
        {
            // Test bestaat altijd uit 3 Delen
            // De Triple AAA

            // Arrange -> Alle nodige data voorzien
            int getal1 = 15;
            int getal2 = 7;

            // Act -> Voer actie uit
            int resultaat = getal1 + getal2;

            // Assert -> Controleer het resultaat van de actie
            Assert.That(resultaat, Is.EqualTo(22));

        }

       
    }
}