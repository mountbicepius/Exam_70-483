using System;
using System.Threading.Tasks;
namespace Chapter1
{
    public static class Program
    {
        public static void Main()
        {
            Task tsk=Task.Run(() =>{
                  for (int x = 0; x < 100; x++)
                {
                    Console.Write('*');
                }
            });
            tsk.Wait();
        }
    }
}