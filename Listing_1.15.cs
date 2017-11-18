using System;
using System.Threading.Tasks;
namespace Chapter1
{
    public static class Program
    {
        public static void Main()
        {
                Task<string> tasks = new Task<string>[3];
                tasks[0] = Task.Run(() => { Thread.Sleep(2000); return boom; });
            tasks[1] = Task.Run(() => { Thread.Sleep(1000); return shaka; });
            tasks[2] = Task.Run(() => { Thread.Sleep(3000); return laka; });
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