using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0430_hanoi_readfile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("이동할 디스크의 개수를 입력해주세요 : ");
            int disk_num = int.Parse(Console.ReadLine());
            int[] arr = { disk_num, 0, 0 };

            string[] lines = File.ReadAllLines("../../../0430_hanoi_writefile/bin/Debug/log.txt");

            for (int i = (int)Math.Pow(2, disk_num) - 1 - disk_num; i < (int)Math.Pow(2, disk_num + 1) - 1 - disk_num - 1; i++)
            {
                string[] value = lines[i].Split(' '); // (disk num) (pole num) (from) (to)

                arr[(int)value[2][0] - (int)'A']--;
                arr[(int)value[3][0] - (int)'A']++;

                Console.Write(" Disk {0,2} | {1} > {2} | ", value[1], value[2], value[3]);
                Console.WriteLine("{0,2} {1,2} {2,2}", arr[0], arr[1], arr[2]);
            }
        }
    }
}

