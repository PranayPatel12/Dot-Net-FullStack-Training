// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace InsuranceManagementSystem
{
    class Security
    {
        public void Authenticate()
        {
            Console.WriteLine("User Authenticated Successfully.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Security security = new Security();
            security.Authenticate();

            // Creating Policies
            InsurancePolicy lifePolicy = new LifeInsurance(101, "Amit", 5000);
            InsurancePolicy healthPolicy = new HealthInsurance(102, "Neha", 3000);

            // Policy Directory
            PolicyDirectory directory = new PolicyDirectory();
            directory.AddPolicy(lifePolicy);
            directory.AddPolicy(healthPolicy);

            // Indexer Usage
            Console.WriteLine(directory[0].policyHolderName);
            Console.WriteLine(directory["Neha"].policyNumber);

            Console.WriteLine("Life Policy Premium: "+lifePolicy.calculatePremium());
            Console.WriteLine("Health Policy Premium: "+healthPolicy.calculatePremium());

            LifeInsurance life = new LifeInsurance(201, "Ravi", 6000);
            InsurancePolicy baseRef = life;

            life.showPolicy();
            baseRef.showPolicy();

        }
    }
}


