using ChainOfResponsabilities.Chains;
using System.Collections.Generic;
using Xunit;

namespace APatternForLifeTests.ChainOfResponsabilities
{
    public class ChainTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void ItShouldCalculateFidelityPointsCorrectly(int totalDistanceOfTravel, int Result)
        {
            var fiveKmFidelityKind = new FiveKmPoints();
            var tenKmFidelityKind = new TenKmPoints();
            var fifteenKmFidelityKind = new FifteenKmPoints();

            fifteenKmFidelityKind._nextKmPoint = tenKmFidelityKind;
            tenKmFidelityKind._nextKmPoint = fiveKmFidelityKind;

            Assert.Equal(Result, fifteenKmFidelityKind.CalculatePoints(totalDistanceOfTravel));
        }

        public static IEnumerable<object[]> TestData =>
            new List<object[]>
            {
                new object[] {7, 7},
                new object[] {14, 28},
                new object[] {22, 66},
                new object[] {2, 0}
            };
    }
}
