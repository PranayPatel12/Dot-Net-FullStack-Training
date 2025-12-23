namespace InsuranceManagementSystem
{
    public class LifeInsurance : InsurancePolicy
    {
        private const double LifeCharge = 500;

        public LifeInsurance(int policyNumber, string holderName, double premium) : base(policyNumber, holderName, premium)
        {
            
        }

        public override double calculatePremium()
        {
            return Premium + LifeCharge;
        }

        public new void showPolicy()
        {
            Console.WriteLine("Life Insurance Policy");
        }
    }
}