namespace TemplateMethod.Template
{
    public class IrTax : SalaryTaxes
    {
        protected override double CalculateMaxTax(double salary)
        {
            return salary * 0.27;
        }

        protected override double CalculateRegularTax(double salary)
        {
            return salary * 0.11;
        }

        protected override bool IsItOverTheRooftop(double salary)
        {
            if (salary >= 4660) return true;
            return false;
        }
    }
}
