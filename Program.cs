namespace UserRegistrationProblem
{
   class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem");
            FirstName LastName = new FirstName();
            Console.WriteLine("Please enter the Last name:");

            string lastName = Console.ReadLine();
            bool val = LastName.ValidateLastName(lastName);

            if (val)
            {
                Console.WriteLine("Last name matched");
            }
            else
            {
                Console.WriteLine("Last name not matched");
            }
        }

    }
}