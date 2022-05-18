using StrategyPattern;
using StrategyPattern.Strategies;
using System.Collections.Generic;
using Xunit;

namespace APatternForLifeTests.StrategyPattern
{
    public class StrategyTest
    {

        [Theory, MemberData(nameof(TestData))]
        public void ItShouldCalculateTaxesCorrectly(double TotalShoppingValue, ITaxes TaxToBePaid, double ExpectedReturn)
        {
            Assert.Equal(ExpectedReturn, TaxCalculator.Calculador(TotalShoppingValue, TaxToBePaid));
        }

        public static IEnumerable<object[]> TestData =>
            new List<object[]>
            {
                    new object[] {5350.45, new IcmsTax(), 535.04},
                    new object[] {5350.45, new IpsTax(), 267.52},
                    new object[] {5350.45, new IpctTax(), 401.28}
            };
    }
}
