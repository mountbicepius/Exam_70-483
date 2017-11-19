using System;
using System.Threading.Tasks;
namespace Chapter1
{
    public static class List_1_9
    {
        public static void Main()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            });
            Console.WriteLine(t.Result); // Displays 42
        }
    }
}