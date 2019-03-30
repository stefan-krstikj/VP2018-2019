using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class InvalidChoiceException : Exception
    {
        public InvalidChoiceException()
           : base(String.Format("Invalid choice! Please enter 0 or 1"))
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            double n;
            Console.WriteLine("Enter your name:");
            userName = Console.ReadLine();
            Console.WriteLine("Welcome {0}!", userName);
            Console.WriteLine("How many numbers?");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Generate numbers (0) or enter numbers? (1)");

            double[] numbers = new double[0]; // new array of size n

            // put the numbers in double[] numbers
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 0)
                numbers = generateNumbers(n);
            else if (choice == 1)
                numbers = enterNumbers(n);
            else
            {
                Console.WriteLine("Wrong choice, exiting...");
                return;
            }          

            // print the numbers in debug console
            System.Diagnostics.Debug.WriteLine("Numbers are: ");
            numbers.ToList().ForEach(i => System.Diagnostics.Debug.WriteLine(i));

            // print the average, minimum and maximum
            printAvgAndMinMax(numbers);
            Console.ReadKey();
        }

        static double[] generateNumbers(double n)
        {
            Random random = new Random(); // new random seed
            double[] numbers = new double[(int)n]; // new numbers array
            for (int i = 0; i < n; i++)
            {
                double currNumber = random.Next(0, 1000); // generate new number from the range
                numbers[i] = currNumber;
            }
            return numbers;
        }

        static double[] enterNumbers(double n)
        {
            Console.WriteLine("Enter numbers:");
            double[] numbers = new double[(int)n];
            for (int i = 0; i < n; i++)
            {
                double currNumber = Convert.ToDouble(Console.ReadLine());
                numbers[i] = currNumber;
            }
            return numbers;
        }

        static void printAvgAndMinMax(double[] numbers)
        {
            double avg = 0;
            double min = double.MaxValue;
            double max = double.MinValue;

            for(int i = 0; i < numbers.Length; i++)
            {
                avg += numbers[i];
                if (numbers[i] < min)
                    min = numbers[i];
                if (numbers[i] > max)
                    max = numbers[i];
            }

            Console.WriteLine("Average of numbers is: {0}\nMinimum number: {1}\nMaximum number: {2}", avg / numbers.Length, min, max);
        }
    }
}
