namespace ChainOfResponsabilities.Chains
{
    public class TenKmPoints : IFidelityPoints
    {
        public IFidelityPoints _nextKmPoint { get; set; }

        public int CalculatePoints(int TraveledDistance)
        {
            if (TraveledDistance < 10)
                return _nextKmPoint.CalculatePoints(TraveledDistance);

            return TraveledDistance * 2;
        }
    }
}
