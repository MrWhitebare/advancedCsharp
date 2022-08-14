using AlgorithmsDotNet.Utils;
using System.Collections.Generic;
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

            int count = algorithms.RecursiveSum(new List<int>() { 15, 0, 10, 50, 55, 35, 15, 20 }),
                max=algorithms.RecursiveMax(new List<int>() { 15, 0, 10, 50, 55, 35, 15, 20 });

            Console.WriteLine($"数组之和:{count},最大值:{max}");

            Console.WriteLine("----QuickSort----");
            List<int> sortArray = algorithms.QuickSort(new List<int>() { 15, 0, 10, 50, 55, 35, 15, 20 });
            foreach (int item in sortArray)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();
        }
    }
}
