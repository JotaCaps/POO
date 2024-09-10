using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2MetodosAbstratos.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures)
            :base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = 0;
            if (AnualIncome < 20000.00)
            {
                tax = AnualIncome * 0.15;
            }
            else if (AnualIncome > 20000.00 && HealthExpenditures != 0)
            {
                tax = (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
            }
            else if (AnualIncome > 20000.00)
            {
                tax = AnualIncome * 0.25;
            }
            return tax;
            ;
        }
    }
}
