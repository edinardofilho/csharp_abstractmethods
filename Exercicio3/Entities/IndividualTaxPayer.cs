namespace Exercicio3.Entities
{
    class IndividualTaxPayer : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public IndividualTaxPayer(double healthExpenditures, string name, double annualIncome) : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnnualIncome < 20000.0)
            {
                return (AnnualIncome * 0.15) - (HealthExpenditures * 0.5);
            } else
            {
                return (AnnualIncome * 0.25) - (HealthExpenditures * 0.5);
            }
        }
    }
}
