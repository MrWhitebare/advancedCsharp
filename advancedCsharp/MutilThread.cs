using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
/*
    多线程
 */
namespace advancedCsharp
{
    class MutilThread
    {
        public static void ThreadProcess(object tag)
        {
            int i = 100;
            while (i>0)
            {
                Console.WriteLine(string.Format("i:{0}", i));
                Thread.Sleep(10);
                i--;
            }
        }

        /*public static void Main(string[] args)
        {
            //创建线程
            Thread thread = new Thread(ThreadProcess);
            thread.Start(new object());

            //线程池
            ThreadPool.QueueUserWorkItem(ThreadProcess, new object());
            //Task方式创建线程
            System.Threading.Tasks.Task.Factory.StartNew(ThreadProcess, new object());

            //终止Thread 线程
            //thread.Abort();
            Console.ReadKey();
        }*/
    }
}
