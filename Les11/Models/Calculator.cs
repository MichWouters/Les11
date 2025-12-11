
namespace Les11.Models
{
    public class Calculator
    {
        public int NummersOptellen(int getal1, int getal2)
        {
            return getal1 + getal2;
        }

        public int NummersAftrekken(int getal1, int getal2)
        {
            int resultaat = getal1 - getal2;

            if(resultaat < 0)
            {
                return 0;
            }
            else
            {
                return resultaat;
            }
        }

        public int NummersVermenigvuldigen(int getal1, int getal2)
        {
            return getal1 * getal2;
        }

        public int NummersDelen(int getal1, int getal2)
        {
            return getal1 / getal2;
        }
    }
}
