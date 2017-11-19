using System;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;
namespace Chapter1
{
    public static class List_1_15
    {
        public static void Main()
        {
            Task<int>[] tasks = new Task<int>[3];
                tasks[0] = Task.Run(() => { Thread.Sleep(2000); return 2; });
                tasks[1] = Task.Run(() => { Thread.Sleep(1000); return 4; });
                tasks[2] = Task.Run(() => { Thread.Sleep(3000); return 6; });
            while (tasks.Length > 0)
            {
                int i = Task.WaitAny(tasks);
                Task<int> completedTask = tasks[i];
                Console.WriteLine(completedTask.Result);
                var temp = tasks.ToList();
                temp.RemoveAt(i);
                tasks = temp.ToArray();
            }
        }
    }
}