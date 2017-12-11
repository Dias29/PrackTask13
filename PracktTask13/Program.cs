using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracktTask13
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList(10);
            for (int index = 0; index < numbers.Capacity; index++)
            {
                numbers.Add(index);
                Console.WriteLine(numbers[index]);

            }
            for (int del = 0; del < numbers.Capacity; del++)
            {
                if ((int)numbers[del] % 2 != 0)
                {
                    // Console.SetCursorPosition
                    Console.WriteLine("_" + numbers[del]);
                }
            }

            Console.ReadLine();
        }
    }
}
