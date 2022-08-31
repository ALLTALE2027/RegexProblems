namespace UserRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RegexProblems!!!!");
            var regex = new UserRegisteration();
            
            //UC1 
            regex.CheckFirstName("Darshan");

            //UC2
            regex.CheckLastName("Deshmukh");

            //UC3
            regex.CheckEmail("abc.100@abc.com.au");

            //UC4
            regex.CheckMobileNumber("91 9123456780");

            //UC5
            regex.CheckPassword8Char("1234abcd");

            //UC6
            regex.CheckPasswordWithUpperCase("Awesome123");
            regex.CheckPasswordWithUpperCase("awesome123");


            //UC7
            regex.CheckPasswordWithSingleNumber("Awesome1");
            regex.CheckPasswordWithSingleNumber("Awesomeno");

            //UC8
            regex.CheckPasswordWithSpecialChar("123456@abcd");
        }
    }
}