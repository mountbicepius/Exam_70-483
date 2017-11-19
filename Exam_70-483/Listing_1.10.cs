using System;
using System.Threading.Tasks;
namespace Chapter1
{
    public static class List_1_10
    {
        public static void Main()
        {
             Task<int> t1=Task.Run(()=> {
                return 42;
             }).ContinueWith((i)=>
             {
                 return i.Result *2;
             }); 
             Console.WriteLine(t1.Result);
        }
    }
}