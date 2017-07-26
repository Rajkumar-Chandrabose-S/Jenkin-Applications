using System;

namespace NoClaimBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            string _name;
            string _policy;
            DateTime _lastClaimDate;
            Console.WriteLine("Enter the name of the policyholder");
            _name = Console.ReadLine();
            Console.WriteLine("Enter the name of the policy");
            _policy = Console.ReadLine();
            Console.WriteLine("Enter the last claim date [MM-DD-YYYY]");
            _lastClaimDate = Convert.ToDateTime(Console.ReadLine());

            if (Convert.ToDateTime("01/01/2017") >= _lastClaimDate.AddYears(2))
            {
                Console.WriteLine("{0}, your policy - ( {1} )  is eligible to get 5% bonus on your claim.", _name, _policy);
            }
            else
            {
                Console.WriteLine("{0}, your policy - ( {1} ) is not eligible to get 5% bonus on your claim.", _name, _policy);
            }
            Console.ReadKey();
        }
    }
}
