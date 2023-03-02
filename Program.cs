namespace UserRegistrationProblem
{
   class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem");
            FirstName Email = new FirstName();
            Console.WriteLine("Please enter the Email:");

            string email = Console.ReadLine();
            bool val = Email.ValidateEmail(email);

            if (val)
            {
                Console.WriteLine("Email matched");
            }
            else
            {
                Console.WriteLine("Email not matched");
            }
        }

    }
}