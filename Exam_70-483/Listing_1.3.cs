using System;
using System.Threading;

namespace chapter1
{
    public static class Program
    {
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.Write("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }
        public static void Main()
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(5);
            t.Join();
        }
    }
}