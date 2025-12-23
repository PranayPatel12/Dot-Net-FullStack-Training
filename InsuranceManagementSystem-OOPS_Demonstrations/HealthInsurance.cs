namespace InsuranceManagementSystem
{
    public class HealthInsurance : InsurancePolicy
    {
        public HealthInsurance(int policyNumber, string holderName, double premium) : base(policyNumber, holderName, premium)
        {
            
        }

        public sealed override double calculatePremium()
        {
            return Premium;
        }

        
    }
}