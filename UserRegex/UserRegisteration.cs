using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegex
{
    internal class UserRegisteration
    {
        public Regex FirstNameRegex = new Regex(@"[A-Z]{1}[A-z a-z]{2,}");   
        public Regex LastNameRegex = new Regex(@"[A-Z]{1}[A-z a-z]{2,}");   
        public Regex EmailRegex = new Regex(@"^[a-z A-Z 0-9 .+_-]+@[a-z A-Z 0-9 -.]+[.][a-z A-Z 0-9 -]{2,}$"); 
        public Regex MobileNumberRegex = new Regex(@"[0-9]{1,2}\s[0-9]{10}"); 
        public Regex PasswordMinchar8 = new Regex(@"[A-Z a-z 0-9]{8,}");   
        public Regex PasswordUpperRegex = new Regex(@"(?=.*[A-Z])[A-Za-z0-9]{8,}");   
        public Regex PasswordDigitRegex = new Regex(@"(?=.*[0-9])[A-Za-z0-9]{8,}");   
        public Regex PasswordSpeciaRegex = new Regex(@"(?=.*[#?!@$%^&*-])[A-Za-z0-9]{8,}");   



        public void CheckFirstName(string FirstName)   
        {
            Console.WriteLine("first name is : " + FirstName);
            if (FirstNameRegex.IsMatch(FirstName))
            {
                Console.WriteLine("Valid first name");
            }
            else
            {
                Console.WriteLine("Invalid first name");
            }
            Console.WriteLine();
        }
        public void CheckLastName(string LastName)   
        {
            Console.WriteLine("last name is : " + LastName);
            if (LastNameRegex.IsMatch(LastName))
            {
                Console.WriteLine("Valid Last name");
            }
            else
            {
                Console.WriteLine("Invalid Last name");
            }
            Console.WriteLine();
        }
        public void CheckEmail(string email)   
        {
            Console.WriteLine("Email Id is : " + email);
            if (EmailRegex.IsMatch(email))
            {
                Console.WriteLine("Valid Email Id");
            }
            else
            {
                Console.WriteLine("Invalid Email Id");
            }
            Console.WriteLine();
        }
        public void CheckMobileNumber(string mobileNumber)
        {
            Console.WriteLine("Mobile number is : " + mobileNumber);
            if (MobileNumberRegex.IsMatch(mobileNumber))
            {
                Console.WriteLine("Valid Number");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }

        public void CheckPassword8Char(string pass)
        {
            Console.WriteLine("password  is : " + pass);
            if (PasswordMinchar8.IsMatch(pass))
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");

            }
        }
        public void CheckPasswordWithUpperCase(string pass)
        {
            Console.WriteLine("Password is : " + pass);
            if (PasswordUpperRegex.IsMatch(pass))
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");

            }
        }

        public void CheckPasswordWithSingleNumber(string pass)
        {
            Console.WriteLine("Password is : " + pass);
            if (PasswordDigitRegex.IsMatch(pass))
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");

            }
        }
        public void CheckPasswordWithSpecialChar(string pass)
        {
            Console.WriteLine("Password is : " + pass);
            if (PasswordSpeciaRegex.IsMatch(pass))
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");

            }
        }
    }
}
