using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extension;

namespace Extension
{
    public static class IntegerExtension
    {
        public static int Facto(this int mint)
        {
            int i, result = 1;
            for (i = 1; i <= mint; i++)
                result *= i;
            return result;
        }
        public static int Permu(this int mint, int n)
        {
            int i, result = 1;
            for (i = 1; i <= n; i++)
                result *= mint--;
            return result;
        }
    }
}
namespace _0416_facto_permu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5..Facto() : {0}", 5.Facto());
            Console.WriteLine("4.Permu(2) : {0}", 4.Permu(2));
            Console.WriteLine("4.Permu(4) : {0}", 4.Permu(4));
        }
    }
}
