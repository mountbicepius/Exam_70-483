using System;
using System.Threading;

namespace exam_70483
{
    public static class program
    {
        public static void threadMethod()
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("ThreadProc: {0}",i);
                Thread.Sleep(0);
            }
        }
        public static void Main(string[] args)
        {
            Thread obj =new Thread(new ThreadStart(threadMethod));
            obj.Start();
             for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(0);
            }
            obj.Join();
            Console.Read();
        }
    }
}