namespace StrategyPattern.Strategies
{
    public class IcmsTax : ITaxes
    {
        public double Calculate(double total)
        {
            return total * 0.1;
        }
    }
}
