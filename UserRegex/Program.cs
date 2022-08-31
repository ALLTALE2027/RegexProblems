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

            ///UC3
            regex.CheckEmail("abc.100@abc.com.au");
        }
    }
}