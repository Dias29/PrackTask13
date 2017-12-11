using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(5);
            Random rnd = new Random();
            int sum = 0;

            for(int i = 0; i<numbers.Capacity; i++)
            {
                int num = rnd.Next(0, 10);
                numbers.Add(num);
                Console.WriteLine(numbers[i]);
                
                sum = sum + numbers[i];

                
            }

            Console.WriteLine("\nSum= " + sum);

            for (int i = 0; i < numbers.Capacity; i++)
            {
                int middleAriphmetic = sum / numbers.Capacity;
                if (numbers[i] > middleAriphmetic)
                {
                    Console.WriteLine("\nNum= " + numbers[i]);
                }
            }

                Console.ReadLine();
        }
    }
}
