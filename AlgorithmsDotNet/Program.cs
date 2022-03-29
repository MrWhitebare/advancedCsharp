using AlgorithmsDotNet.Utils;
using System;

namespace AlgorithmsDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] my_list = new int[5] { 1, 3, 5, 7, 9 };
            int order = algorithms.BinarySearch(my_list, 9);
            Console.WriteLine("序号:{0}", order);

            int[] my_array = { 15, 0, 10, 50, 55, 35, 15, 20 };
            int[] newArray = algorithms.SelectSort(my_array);
            //int[] newArray = algorithms.SelectSortArray(my_array);
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i].ToString() + "\t");
            }


            //递归
            algorithms.CountDown(10);
            //阶乘
            int fac = algorithms.Factorial(7);
            Console.WriteLine("7的阶乘结果是:{0}", fac);

            //汉诺塔
            algorithms.HanoiTower(3, "A塔", "B塔", "C塔");

            Console.ReadKey();
        }
    }
}
