namespace InsuranceManagementSystem
{
    public class PolicyDirectory
    {
        private List<InsurancePolicy> policies = new List<InsurancePolicy>();

        public void AddPolicy(InsurancePolicy policy)
        {
            policies.Add(policy);
        }

        public InsurancePolicy this[int index]
        {
            get { return policies[index]; }

        }

        public InsurancePolicy this[string name]
        {
            get
            {
                foreach (var policy in policies)
                {
                    if(policy.policyHolderName == name)
                    {
                        return policy;
                    }
                }
                return null;
            }
        }
    }
}