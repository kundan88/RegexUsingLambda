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
        public Regex PasswordR = new Regex("^[a-zA-Z0-9]{8,}$");
        public Regex PasswordR2 = new Regex("^(?=.*[A-Z])[a-zA-Z0-9]{8,}$");
        public Regex PasswordR3 = new Regex("^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9]{8,}$");
        public Regex PasswordR4 = new Regex("^(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*])[a-zA-Z0-9]{8,}$");
        public Regex CheckEmailR = new Regex("^[a-z]{3,}(([.|+]{1})?([-]{1})?[0-9]{1,})?@[a-z0-9]{1,}.[a-z]{3}(.[a-z]{2,4})?$");


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

        public string validPassword(string Password)
        {
            bool PasswordPattern(string PasswordPattern) => PasswordR.IsMatch(Password);
            bool result = PasswordPattern(Password);
            
            
                if (result == false)
                {
                Console.WriteLine("Password is Invalid");
                }
                
                else
                {
                Console.WriteLine("Password is valid");
                }
               return Password;
        }
        public string validPasswordR2(string Password2)
        {
            bool PasswordR2Pattern(string PasswordR2Pattern) => PasswordR.IsMatch(Password2);
            bool result = PasswordR2Pattern(Password2);
            
                if (result == false)
                {
                    Console.WriteLine("Password is Invalid");
                }
                else
                {
                    Console.WriteLine("Password is valid");
                }
            return Password2;
            
        }
        public string validPasswordR3(string Password3)
        {
            bool PasswordR3Pattern(string PasswordR3Pattern) => PasswordR.IsMatch(Password3);
            bool result = PasswordR3Pattern(Password3);
            
                if (result == false)
                {
                Console.WriteLine("Password is Invalid");
                }
                            
               else
               {
                Console.WriteLine("Password is Invalid");
               }
               return Password3;
        }

        public string validPasswordR4(string Password_4)
        {
            bool PasswordR4Pattern(string PasswordR4Pattern) => PasswordR.IsMatch(Password_4);
            bool result = PasswordR4Pattern(Password_4);
            
                if (result == false)
                {
                    Console.WriteLine("Password is Invalid");
                }               
            
                else
                {
                    Console.WriteLine("Password is valid");
                }
               return Password_4;
        }
        public string validCheckEmailSample(string CheckEmail)
        {
            bool CheckEmailPattern(string CheckEmailPattern) => CheckEmailR.IsMatch(CheckEmail);
            bool result = CheckEmailPattern(CheckEmail);
            
                if (result == false)
                {
                Console.WriteLine("Email is Invalid");
                }
                           
                else
                {
                  Console.WriteLine("Email is valid");
                }
                return CheckEmail;
        }
    }
}
