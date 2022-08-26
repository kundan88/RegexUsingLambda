using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUsingLambda
{
    public class UserRegistration
    {
        public Regex FirstNameR = new Regex("^[A-Z]{1}[a-zA-Z]{2,}$");
        public Regex LastNameR = new Regex("^[A-Z]{1}[a-zA-Z]{2,}$");
        public string ValidFirstName(string FirstName)
        {
            bool FirstNamePattern(string FirstNamePattern) => FirstNameR.IsMatch(FirstName);
            bool result = FirstNamePattern(FirstName);


            if (result == false)
            {
                Console.WriteLine("First Name is Invalid");

            }

            else
            {
                Console.WriteLine("First Name is valid");
            }
            return "FirstName;
        }

        public string validLastName(string LastName)
        {
            bool LastNamePattern(string LastNamePattern) => LastNameR.IsMatch(LastName);
            bool result = LastNamePattern(LastName);
            
                if (result == false)
                {
                Console.WriteLine("Last Name is Invalid");
                }
               
                else
                {
                 Console.WriteLine("Last Name is valid");
                }
                 return LastName;
        }
    }
}
