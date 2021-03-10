using System;

namespace Standard_Deviation
{
    class Program
    {
        static void Main(string[] args)
        {
            getData();
        }
        static void getData()
        {
            Console.Write("Please enter how many nr are there: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n+1];
            for (int i = 1; i<=n; i++)
            {
                Console.Write("{0} ) ", i);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
