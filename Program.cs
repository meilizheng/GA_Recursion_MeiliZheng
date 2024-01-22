namespace GA_Recursion_MeiliZheng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose the number:");
            Console.WriteLine("1: PrintNumbersFrom1To10");
            Console.WriteLine("2: CountDownAndUp");
            Console.WriteLine("3: CalculateSum");
            Console.WriteLine("4: Fibonacci");
            int userInput;
            if (int.TryParse(Console.ReadLine(), out userInput))
            {
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Please enter a number.");
                        int enteredNumber;
                        if (int.TryParse(Console.ReadLine(), out enteredNumber))
                        {
                            Console.WriteLine($"print {enteredNumber} - 10:");
                            PrintNumbersFrom1To10(enteredNumber);
                        }
                        else
                        {
                            Console.WriteLine("Please enter the valid number");
                        }
                        break;
                    case 2:
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Please choose the valid number.");
                        return;
                }
            }
        }

        static void PrintNumbersFrom1To10(int num)
        {
            if (num <= 10)
            {               
                Console.WriteLine(num);
                num++;
                PrintNumbersFrom1To10(num);
            }
        }
    }
}