using System.Collections.Generic;
using TemplateMethod.Template;
using Xunit;

namespace APatternForLifeTests.TemplateMethod
{
    public class TemplateTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void ItShouldCalculateSalaryTaxesCorrectly(double salary, SalaryTaxes taxClass , double expectedReturn)
        {
            Assert.Equal(expectedReturn, taxClass.CalculateSalaryTax(salary));
        }

        public static IEnumerable<object[]> TestData =>
            new List<object[]>
            {
                new object[] {1500, new InssTax(), 180},
                new object[] {2687.50, new IrTax(), 295.62},
                new object[] {5300, new InssTax(), 1325},
                new object[] {4660, new IrTax(), 1258.20},
            };
    }
}
