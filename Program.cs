namespace UserRegistrationProblem
{
   class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem");

          FirstName firstname = new FirstName();

            Console.Write("Enter Your First Name : ");

            string FirstName = Console.ReadLine();

            bool val = firstname.ValidateFirstName(FirstName);

            if (val)
            {
                Console.WriteLine("FirstName is Valid");
            }
            else
            {
                Console.WriteLine("Invalid FirstName");
            }
        }

    }
}