namespace Fibonacci
{
    internal class Program
    {
        public static int Factorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else if (number == 0)
            {
                return 0;
            }
            else return (number * Factorial(number - 1));

        }

        // Fibonacci with recursion
        //public static int Fibonacci(int number)
        //{
        //    if (number == 1)
        //    {
        //        return 1;
        //    }
        //    else if (number == 0)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        int x = Fibonacci(number - 1);
        //        int y = Fibonacci(number - 2);
        //        return x + y;
        //    }
        //}

        // FibonacciSeries in loops

        public static int FibonacciSeries(int number)
        {
            int firstNumber = 0, secondNumber = 1, result = 0;

            if (number == 1)
            {
                return 1;
            }
            else if (number == 0)
            {
                return 0;
            }
            else
            {
                for (int i = 2; i <= number; i++)
                {
                    result = firstNumber + secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = result;


                }
                return result;
            }
            
        }

        static void Main(string[] args)
        {
            //    Console.Write("Enter a number to calculate its factorial: ");
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    int fact = Factorial(number);
            //    Console.WriteLine("The factorial of {0} is {1}.", number, fact);



            //int result = Fibonacci(8);
            //Console.WriteLine(result);

            int result = FibonacciSeries(1000);
            Console.WriteLine(result);
        }
    }
}