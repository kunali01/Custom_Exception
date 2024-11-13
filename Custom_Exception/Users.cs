using System;

namespace Custom_Exception
{
    // Custom Exception Class for Age Validation
    public class AgeException : Exception
    {
        public AgeException(string message) : base(message) { }
    }

    public class Users
    {
        private int age;
        private string name;

        public Users(int age, string name)
        {
            if (age >= 18)
            {
                this.age = age;
            }
            else
            {
                throw new AgeException(age + " is not allowed. Age must be 18 or older.");
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name is required.");
            }

            this.name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Provide both age and name parameters
                Users user = new Users(15, "John");
            }
            catch (AgeException ex)
            {
                Console.WriteLine("Age Exception: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Argument Exception: " + ex.Message);
            }
        }
    }
}
