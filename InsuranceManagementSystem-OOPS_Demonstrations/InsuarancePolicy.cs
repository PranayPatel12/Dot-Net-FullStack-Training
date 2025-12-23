namespace InsuranceManagementSystem
{
    public class InsurancePolicy
    {
        public int policyNumber{ get; init; }
        public string policyHolderName{ get; set; }
        private double premium;

        public double Premium
        {
            get => premium;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Premium cannot be negative.");
                }
                premium = value;
            }
        }

        public InsurancePolicy(int policyNumber, string holderName, double premium)
        {
            this.policyNumber = policyNumber;
            policyHolderName = holderName;
            Premium = premium;
        }

        public virtual double calculatePremium()
        {
            return Premium;
        }

        public void showPolicy()
        {
            Console.WriteLine("Insurance Policy");
        }

    }
}