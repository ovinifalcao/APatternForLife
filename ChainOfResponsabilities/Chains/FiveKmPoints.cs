namespace ChainOfResponsabilities.Chains
{
    public class FiveKmPoints : IFidelityPoints
    {
        public int CalculatePoints(int TraveledDistance)
        {
            if (!(TraveledDistance >= 5))
                return 0;

            return TraveledDistance;
        }
    }
}
