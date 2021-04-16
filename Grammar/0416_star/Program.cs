using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0416_star
{
    class Program
    {
        static void print_star_1(int cnt)
        {
            int i, j;
            for(i=0; i<cnt; i++)
            {
                for (j = 0; j < i; j++)
                    Console.Write("* ");
                Console.WriteLine("");
            }
        }
        static void print_star_2(int cnt)
        {
            int i, j;
            for(i=cnt; i>0; i--)
            {
                for (j = 0; j < i; j++)
                    Console.Write("* ");
                Console.WriteLine("");
            }
        }
        static void print_star_3(int cnt)
        {
            int i, j;
            for(i=0; i<cnt; i++)
            {
                for(j=0; j<cnt; j++)
                {
                    if (j < i) Console.Write("  ");
                    else Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }
        static void print_star_4(int cnt)
        {
            int i, j;
            for (i = cnt; i > 0; i--)
            {
                for (j = 0; j < cnt; j++)
                {
                    if (j < i) Console.Write("  ");
                    else Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());

            Console.WriteLine("print star. type 1");
            print_star_1(cnt);

            Console.WriteLine("\nprint star. type 2");
            print_star_2(cnt);

            Console.WriteLine("\nprint star. type 3");
            print_star_3(cnt);

            Console.WriteLine("\nprint star. type 4");
            print_star_4(cnt);
        }
    }
}
