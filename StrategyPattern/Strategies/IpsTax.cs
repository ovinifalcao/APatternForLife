namespace StrategyPattern.Strategies
{
    public class IpsTax : ITaxes
    {
        public double Calculate(double total)
        {
            return total * 0.05;
        }
    }
}
