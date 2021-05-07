using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0430_hanoi_readfile
{
    interface ILogger
    {
        void WriteLog(string message);
    }
    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }
    class FileLogger : ILogger
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }
        public void WriteLog(string message)
        {
            writer.WriteLine("{0}", message);
        }

    }
    class ClimateMonitor
    {
        private ILogger logger;
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }
        public void move(int disk, int n, char from, char to)
        {
            logger.WriteLog(disk.ToString() + " " + n.ToString() + " " + from + " " + to);
        }
        void hanoi(int disk, int n, char from, char to, char via)
        {
            if (n == 1) move(disk, n, from, to);
            else
            {
                hanoi(disk, n - 1, from, via, to);
                move(disk, n, from, to);
                hanoi(disk, n - 1, via, to, from);
            }
        }
        public void start()
        {
            int i;
            for (i = 1; i <= 12; i++)
            {
                hanoi(i, i, 'A', 'B', 'C');
                Console.WriteLine("{0} 번째 하노이 결과 파일에 기록 완료", i);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClimateMonitor moniter = new ClimateMonitor(new FileLogger("log.txt"));
                moniter.start();
        }
    }
}

