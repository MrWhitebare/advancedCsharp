#define DEBUG
using System;
using System.Diagnostics;

namespace advancedCsharp
{
    public class Myclass
    {
        [Conditional("DEBUG")]
        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    class Test
    {
        /*static void Main(string[] args)
        {
            Myclass.Message("In Main function.");
            function1();
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }*/
        static void function1()
        {
            Myclass.Message("In Function 1.");
        }
        static void function2()
        {
            Myclass.Message("In Function 2.");
        }
    }
}
