
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0423_interface
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
        public void start()
        {
            while (true)
            {
                Console.Write("온도를 입력해주세요 : ");
                string temp = Console.ReadLine();
                if (temp == "") break;
                logger.WriteLog("현재온도 : " + temp);
            }
        }
    }
    class Program
    {
        // 사용자가 입력한 온도와 현재시간을 파일에 저장한다.
        // visual studio 기준 파일 경로 : bin/Debug/<파일 이름>
        static void Main(string[] args)
        {
            ClimateMonitor moniter = new ClimateMonitor(
                new FileLogger("log.txt"));
            moniter.start();
        }
    }
}
