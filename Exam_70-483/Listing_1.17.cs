using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace exam_70483
{
    public static class List_1_17
    {
        public static void Main()
        {
            ParallelLoopResult result =
            Parallel.
            For(0, 1000, (int i, ParallelLoopState loopState) =>
            {
                if (i == 500)
                {
                    Console.WriteLine("Breaking loop");
                    loopState.Break();
                }
                return;
            });

        }
    }
}