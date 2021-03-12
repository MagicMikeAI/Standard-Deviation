using System;
using System.Linq;
using System.Text;

namespace Standard_Deviation
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("\n\n\t\tThis program will calculate the Standard Deiation.\n\n\n");


            // Getting the inputs and save them into an array.
            Console.Write("Please enter how many nr are there: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("----) ", i);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Step 1: calculate the mean
            int mean = Convert.ToInt32(numbers.Average());
            Console.WriteLine("\n\nStep 1 - Calculate the Mean:\n\n\t" + mean+"\n");

            // Step 2 Subtract the mean from each value (to calculate the deviation)
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] - mean;
            }

            // For debuging...
            Console.WriteLine("Step 2 - Subtracting the Mean from each number:\n");
            foreach (var item in numbers)
            {
                Console.Write("\t"+item.ToString()+"");
            }

            // Step 3: Square each of these results
            Console.WriteLine("\n\nStep 3 - Square each of the results\n\t");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = (int)Math.Pow(numbers[i], 2);
            }
            foreach (var item in numbers)
            {
                Console.Write("\t"+item.ToString());
            }

            // Step 4: Add then all together
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            Console.WriteLine("\n\nStep 4 - Add all numbers together\n\n\t" + sum+"\n");

            // Step 5: Divide by: “number of data items”

            float divideBy = sum / numbers.Length;
            Console.WriteLine("Step 5 - Divide by by number of data items:\n\n\t" + sum + " / " + numbers.Length + " = " + divideBy+"\n");

            //Step 6: Take the square root of the variance to find the standard deviation

            Console.OutputEncoding = Encoding.Unicode;
            double sdv = Math.Sqrt(divideBy);
            Console.WriteLine("Step 6 - Take the square root of the variance to find the standard deviation\n\n\t\u221A"+ divideBy+" = "+sdv);
            Console.ReadKey();
        }
    }
}
