namespace ExercicioAbstract.Entities
{
    class Company : Payer
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {
        }

        public Company(string name, double anualIncome, int numberOfEmployees)
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;    
        }

        public override double Tax()
        {
            if (NumberOfEmployees <= 10)
            {
                return base.AnualIncome * 0.16;
            }
            else
            {
                return base.AnualIncome * 0.14;
            }
        }
    }
}