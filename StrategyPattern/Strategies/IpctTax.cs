namespace StrategyPattern.Strategies
{
    public class IpctTax : ITaxes
    {
        public double Calculate(double total)
        {
            return total * 0.075;
        }
    }
}
