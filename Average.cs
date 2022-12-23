using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgrorithCh20as1  
{
    class Average
    {
        static void Main(string[] args)
        {
            int total = 0;
            int GreatCounter = 1;
            while (GreatCounter <= 10)
            {

                Console.Write("Next Grade : ");
                int input = Convert.ToInt32(Console.ReadLine());
                total += input;
                GreatCounter++;

            }
            int average = (total / 10);
            Console.WriteLine($"Average : {average}");
            Console.WriteLine("Press any key to the window");
            Console.ReadKey();
        }
    }
}
