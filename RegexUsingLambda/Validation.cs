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
        public Regex EmailR = new Regex("^[A-Za-z]{3,}@[a-z]{3,}.[a-z]{3,}$");
        public Regex MobileNoR = new Regex("^[0-9]{2}[ ][6-9]{1}[0-9]{9}$");

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
            return FirstName;
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

        public string validEmail(string Email)
        {
            bool EmailPattern(string EmailPattern) => EmailR.IsMatch(Email);
            bool result = EmailPattern(Email);
            
                if (result == false)
                {
                    Console.WriteLine("EmailId is Invalid");
                }
                
                else
                {
                Console.WriteLine("EmailId is valid");
                }
               return Email;
        }

        public string validMobileNo(string MobileNo)
        {
            bool MobileNoPattern(string MobileNoPattern) => MobileNoR.IsMatch(MobileNo);
            bool result = MobileNoPattern(MobileNo);
            
                if (result == false)
                {
                Console.WriteLine("Mobile Number is not Valid");
                }
               else            
               {
                Console.WriteLine("Mobile Number is Valid");
            }
            return MobileNo;
        }
    }
}
