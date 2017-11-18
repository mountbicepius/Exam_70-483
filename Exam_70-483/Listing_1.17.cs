using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
namespace Chapter1
{
    public static class Program
    {
        public static void Main()
        {
                ParallelLoopResult result = Parallel.
                    Invoke(ParallelOptions parallelLoop ,(add) => 
                {
                    if (i == 500)
                {
                Console.WriteLine("Breaking loop");
                       loopState.Break();
                }
                    return;
                });
        }
        public static void add(int b)
        {
            int a = 0;
            a= a + b;
        }
    }
}