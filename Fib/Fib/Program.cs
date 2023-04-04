using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fib
{
    //https://www.mathsisfun.com/numbers/fibonacci-sequence.html
    /*
     * Jade Gorton u3158046
     */
    class Program
    {
        static void Main(string[] args)
        {
            int output = -1;
            do
            {
                Console.Clear();
                Console.WriteLine("Write LineInput: ");
                Int32.TryParse(Console.ReadLine(), out output);
            } while (output <= 0);
            if (output >= 30)
                Console.WriteLine("Working, might Take long time: " + (Math.Pow(output,2)) + " processing steps");
            Console.WriteLine(Fib(output));
            Console.ReadLine();
        }

        public static int Fib(int n)
        {
            if (n < 0)
                return 0;
            if (n == 1)
                return 1;
            return (Fib(n-1) + Fib(n-2));
        }
    }
}
