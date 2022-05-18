namespace TemplateMethod.Template
{
    public abstract class SalaryTaxes
    {
        public double CalculateSalaryTax(double salary)
        {
            if(IsItOverTheRooftop(salary))
                return Math.Round(CalculateMaxTax(salary),2);

            return Math.Round(CalculateRegularTax(salary),2);
        }

        protected abstract bool IsItOverTheRooftop(double salary);

        protected abstract double CalculateMaxTax(double salary);

        protected abstract double CalculateRegularTax(double salary);
    }
}
