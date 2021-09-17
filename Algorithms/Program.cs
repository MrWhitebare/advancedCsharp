using System;

namespace Algorithms
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
                Console.Write(newArray[i].ToString()+"\t");
            }
            Console.ReadKey();
        }
    }
}
