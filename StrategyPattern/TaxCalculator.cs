using StrategyPattern.Strategies;

namespace StrategyPattern
{
    public class TaxCalculator
    {
        public static double Calculador(double total, ITaxes tax)
        {
            return Math.Round( tax.Calculate(total), 2);
        }
    }
}
