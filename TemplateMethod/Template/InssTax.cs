namespace TemplateMethod.Template
{
    public class InssTax : SalaryTaxes
    {
        protected override double CalculateMaxTax(double salary)
        {
            return salary * 0.25;
        }

        protected override double CalculateRegularTax(double salary)
        {
            return salary * 0.12;
        }

        protected override bool IsItOverTheRooftop(double salary)
        {
            if (salary >= 5300) return true;
            return false;
        }
    }
}
