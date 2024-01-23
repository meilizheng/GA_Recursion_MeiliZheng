namespace GA_Recursion_MeiliZheng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display menu options
            Console.WriteLine("Please choose the number:");
            Console.WriteLine("1: PrintNumbersFrom1To10");
            Console.WriteLine("2: CountDownAndUp");
            Console.WriteLine("3: CalculateSum");
            Console.WriteLine("4: Fibonacci");

            // Get user input
            int userInput;
            if (int.TryParse(Console.ReadLine(), out userInput))
            {
                switch (userInput)
                {
                    case 1:

                        // Print numbers from 1 to 10 based on user input
                        Console.WriteLine("Count to 10:");
                        Console.WriteLine("Please enter a number.");
                        int enteredNumber;
                        if (int.TryParse(Console.ReadLine(), out enteredNumber))
                        {
                            Console.WriteLine($"print {enteredNumber} - 10:");
                            PrintNumbersFrom1To10(enteredNumber);
                        }
                        else
                        {
                            Console.WriteLine("Please enter the valid number.");
                        }
                        break;
                    case 2:

                        // Count down and up based on user input
                        Console.WriteLine("Count down and up:");
                        Console.WriteLine("Please enter a number:");
                        int enterNumber;
                        if(int.TryParse(Console.ReadLine(),out enterNumber))
                        {
                            Console.WriteLine("Count Down:");
                            CountDownAndUp(enterNumber);
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid number.");
                        }

                        break;
                    case 3:

                        // Calculate the sum of an array
                        Console.WriteLine("Calculate sum of a array:");
                        CalculateSum();
                        break;
                    case 4:
                        // Generate and print the Fibonacci sequence
                        Console.WriteLine("Fibonacci Sequence:");

                        int n = 10; 

                        for (int i = 0; i < n; i++)
                        {
                            int fibonacciNumber = Fibonacci(i);
                            Console.Write(fibonacciNumber + " ");
                        }

                        break;
                    default:
                        // Invalid choice
                        Console.WriteLine("Please choose the valid number.");
                        return;
                }
            }
        }

        // Methods for the selected operations
        static void PrintNumbersFrom1To10(int num)
        {

            // Base case: if 'num' is less than or equal to 10, print 'num' and increment it
            if (num <= 10)
            {               
                Console.WriteLine(num);
                num++;
                PrintNumbersFrom1To10(num);
            }
        }

        static void CountDownAndUp(int num)
        {

            // Base case: if 'num' is greater than or equal to 1
            if (num >= 1)
            {
                // Print 'num' (countdown phase)
                Console.WriteLine(num);
                // Recursive call with 'num' decremented
                CountDownAndUp(num - 1);
                // Print 'num' again (count-up phase) moved inside the condition
                Console.WriteLine(num); 
            }
        }

        static void CalculateSum()
        {
            // Array of numbers
            int[] numbers = { 10, 2, 13, 4, 16 };
            int sum = 0;

            // Iterate through each number in the array
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
                // Add the current number to the sum
                sum += number;
            }
            // Print the sum of the array
            Console.WriteLine($"The sum of the arry is {sum}");
        }

        static int Fibonacci(int n)
        {
            // Base case: if 'n' is 0 or 1, return 'n'
            if (n <= 1)
            {
                return n;
            }
            else
            {
                // Recursive case: return the sum of the two preceding Fibonacci numbers
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}