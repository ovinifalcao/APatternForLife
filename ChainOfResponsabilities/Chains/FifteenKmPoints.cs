namespace ChainOfResponsabilities.Chains
{
    public class FifteenKmPoints : IFidelityPoints
    {
        public IFidelityPoints _nextKmPoint { get; set; }

        public int CalculatePoints(int TraveledDistance)
        {
            if (TraveledDistance < 15)
                return _nextKmPoint.CalculatePoints(TraveledDistance);

            return TraveledDistance * 3;
        }
    }
}
