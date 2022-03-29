#define NoBug

using System;
using System.Diagnostics;

namespace advancedCsharp
{
    /// <summary>
    /// 通过Atrribute 实现对代码分类调用
    /// </summary>
    public class CategoryAttribute
    {
        //public static void Main(string[] args)
        //{
        //    //符合条件调用
        //    ToolKit.FunA();
        //    ToolKit.FunB();
        //    ToolKit.FunC();
        //    ToolKit.FunD();
        //}
    }

    class ToolKit
    {
        [ConditionalAttribute("Li")]
        [ConditionalAttribute("Buged")]
        public static void FunA()
        {
            Console.WriteLine("Created By Li, Buged.");
        }

        [Conditional("Li")]
        [Conditional("NoBug")]
        public static void FunB()
        {
            Console.WriteLine("Created By Li, NoBug");
        }

        [ConditionalAttribute("Zhang")]
        [Conditional("Buged")]
        public static void FunC()
        {
            Console.WriteLine("Created By zhang,Buged.");
        }

        [Conditional("Zhang")]
        [Conditional("NoBug")]
        public static void FunD()
        {
            Console.WriteLine("Created By Zhang,NoBug");
        }
    }
}
