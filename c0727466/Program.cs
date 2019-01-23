using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0727466
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;

            while (i <= 5)
            {
                sum += i;
                i++;
            }
            Console.WriteLine("The sum of {0} ", sum);
            Console.ReadLine();




       } 
    }
}
