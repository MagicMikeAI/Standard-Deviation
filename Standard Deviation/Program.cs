using System;
using System.Linq;

namespace Standard_Deviation
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0; 

            Console.Write("Please enter how many nr are there: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("----) ", i);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }


            // For debuging...
            foreach (var item in numbers)
            {
                Console.WriteLine(item.ToString());
            }

            // Getting the mean
            int mean = Convert.ToInt32(numbers.Average());
            Console.WriteLine("Average is: " + mean);

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] - mean;
            }

            // For debuging...
            foreach (var item in numbers)
            {
                Console.WriteLine(item.ToString());
            }

            // Getting the square for each 
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = (int)Math.Pow(numbers[i], 2);
            }

            // For debuging...
            foreach (var item in numbers)
            {
                Console.WriteLine(item.ToString());
            }

            for ( int i = 0; i<numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            Console.WriteLine("The sum is: " + sum);
            int divideBy = sum / numbers.Length;
            Console.WriteLine("The Devide is: " + divideBy);
            double sdv = Math.Sqrt(divideBy);
            Console.WriteLine("The sdv is: " + sdv);


        }

    }
}
