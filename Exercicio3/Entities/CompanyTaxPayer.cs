namespace Exercicio3.Entities
{
    class CompanyTaxPayer : TaxPayer
    {
        public int Employees { get; set; }

        public CompanyTaxPayer(int employees, string name, double annualIncome) : base(name, annualIncome)
        {
            Employees = employees;
        }

        public override double Tax()
        {
            if (Employees <= 10)
            {
                return AnnualIncome * 0.16;
            } else
            {
                return AnnualIncome * 0.14;
            }
        }
    }
}
