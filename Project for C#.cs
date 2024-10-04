using System;

namespace DivisionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            string input1 = Console.ReadLine();

            Console.WriteLine("Enter the second number:");
            string input2 = Console.ReadLine();

            PerformDivision(input1, input2);
        }

        static void PerformDivision(string num1, string num2)
        {
            try
            {
                int dividend = Convert.ToInt32(num1);
                int divisor = Convert.ToInt32(num2);
                
                int result = dividend / divisor;
                Console.WriteLine($"The result of {dividend} divided by {divisor} is: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: One of the inputs is not a valid integer format.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: One of the numbers is too large or too small.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
