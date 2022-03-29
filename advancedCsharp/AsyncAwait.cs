using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace advancedCsharp
{
    class AsyncAwait
    {
        //public static void Main(string[] arg)
        //{
        //    callMethod();
        //    Console.ReadKey();
        //}

        public static async void callMethod()
        {
            Task<int> task = Method1();
            task.Wait();
            Method2();
            int count = await task;
            Method3(count);
        }
        public static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 1");
                    count += 1;
                }
            });
            return count;
        }

        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
            }
        }

        public static void Method3(int count)
        {
            Console.WriteLine("Total count is " + count);
        }
    }
}
