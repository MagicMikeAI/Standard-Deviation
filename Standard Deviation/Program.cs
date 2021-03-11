using System;
using System.Linq;

namespace Standard_Deviation
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;


            // Getting the inputs and save them into an array.
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

            // Step 1: calculate the mean

            int mean = Convert.ToInt32(numbers.Average());
            Console.WriteLine("Average is: " + mean);

            // Step 2 Subtract the mean from each value (to calculate the deviation)



            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] - mean;
            }

            // For debuging...
            foreach (var item in numbers)
            {
                Console.WriteLine(item.ToString());
            }

            // Step 3: Square each of these results
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = (int)Math.Pow(numbers[i], 2);
            }

            // For debuging...
            foreach (var item in numbers)
            {
                Console.WriteLine(item.ToString());
            }

            // Step 4: Add then all together
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            Console.WriteLine("The sum is: " + sum);

            // Step 5: Divide by: “number of data items”

            int divideBy = sum / numbers.Length;
            Console.WriteLine("The Devide is: " + divideBy);

            //Step 6: Take the square root of the variance to find the standard deviation
            double sdv = Math.Sqrt(divideBy);
            Console.WriteLine("The sdv is: " + sdv);


        }
    }
}
