using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0423_hanoi
{
    interface ILogger
    {
        void WriteLog(string message);
    }
    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(
                "{0} {1}", DateTime.Now.ToLocalTime(), message);
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
            writer.WriteLine("{0} {1}", DateTime.Now.ToShortDateString(), message);
        }

    }
    class ClimateMonitor
    {
        private ILogger logger;
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }
        public void move(int n, char from, char to)
        {
            logger.WriteLog(n.ToString() + " : " + from + "->" + to);
        }
        void hanoi(int n, char from, char to, char via)
        {
            if (n == 1) move(n, from, to);
            else
            {
                hanoi(n - 1, from, via, to);
                move(n, from, to);
                hanoi(n - 1, via, to, from);
            }
        }
        public void start()
        {
            Console.Write("이동할 원판의 개수를 입력해주세요 : ");
            int num = Convert.ToInt32(Console.ReadLine());
            hanoi(num, 'A', 'B', 'C');
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClimateMonitor moniter = new ClimateMonitor(
                new FileLogger("log.txt"));
            moniter.start();
        }
    }
}
