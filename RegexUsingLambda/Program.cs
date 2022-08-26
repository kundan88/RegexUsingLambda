namespace RegexUsingLambda
{
    class Program
    {
        public static void Main(string[] args)
        {
            //UC1
            UserRegistration userRegistration = new UserRegistration();
            Console.WriteLine("Enter First name");
            string fName = Console.ReadLine();
            userRegistration.ValidFirstName(fName);

            //UC2
            Console.WriteLine("Enter Last name");
            string LastName = Console.ReadLine();
            userRegistration.validLastName(LastName);
        }
    }
}