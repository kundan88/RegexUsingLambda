namespace RegexUsingLambda
{
    class Program
    {
        public static void Main(string[] args)
        {
            UserRegistration userRegistration = new UserRegistration();
            Console.WriteLine("Enter First name");
            string fName = Console.ReadLine();
            userRegistration.ValidFirstName(fName);
        }
    }
}