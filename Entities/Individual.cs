namespace ExercicioAbstract.Entities
{
    class Individual : Payer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (base.AnualIncome < 20000)
            {
                return AnualIncome * 0.15 
                    - HealthExpenditures * 0.50;
            }
            else
            {
                return AnualIncome * 0.25 
                    - HealthExpenditures * 0.50;
            }
        }
    }
}