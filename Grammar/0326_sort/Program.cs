using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0326_sort
{
    class Program
    {
        static void func(params int[] args)
        {
            Array.Sort(args);
            if (args.Length % 2 == 1)
                Array.Reverse(args);

            int i;
            for (i = 0; i < args.Length; i++)
                Console.Write(args[i].ToString()+" ");
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            func(6, 3);
            func(3, 9, 6);
            func(1, 4, 3, 8);
        }
    }
}
