using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsDotNet.Utils
{
    /// <summary>
    /// 算法集合类
    /// </summary>
    class algorithms
    {
        /// <summary>
        /// 二分查找有序列表
        /// </summary>
        /// <param name="orderList">有序列表</param>
        /// <param name="desValue">目标值</param>
        /// <returns></returns>
        public static int BinarySearch(int[] orderList, int desValue)
        {
            int low = 0;
            int high = orderList.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                int guess = orderList[mid];
                if (guess == desValue) return mid;
                if (guess < desValue)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return -1;
        }

        /// <summary>
        /// 查找数组中的最小值
        /// </summary>
        /// <param name="iArray">待筛选数组</param>
        /// <returns></returns>
        private static int FindSmallest(int[] iArray)
        {
            int smallest = iArray[0];
            int smallestIndex = 0;
            for (int i = 0; i < iArray.Length; i++)
            {
                if (smallest > iArray[i])
                {
                    smallest = iArray[i];
                    smallestIndex = i;
                }
            }
            return smallestIndex;
        }

        /// <summary>
        /// 删除数组中指定项，并返回新数组
        /// </summary>
        /// <param name="iArray">原数组</param>
        /// <param name="index">删除项</param>
        /// <returns></returns>
        private static int[] RemoveListItem(int[] iArray, int index)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < iArray.Length; i++)
            {
                if (i != index)
                {
                    arrayList.Add(Convert.ToInt32(iArray[i]));
                }
            }
            int[] newArray = new int[arrayList.Count];
            int j = 0;
            while (j < newArray.Length)
            {
                newArray[j] = (int)arrayList[j];
                j++;
            }
            return newArray;
        }

        /// <summary>
        /// 选择排序，返回排序后结果
        /// </summary>
        /// <param name="iArray">待筛选数组</param>
        /// <returns></returns>
        public static int[] SelectSort(int[] iArray)
        {
            int[] newArray = new int[iArray.Length];
            for (int i = 0; i < newArray.Length; i++)
            {
                int smallestIndex = FindSmallest(iArray);
                newArray[i] = iArray[smallestIndex];
                iArray = RemoveListItem(iArray, smallestIndex);
            }
            return newArray;
        }

        /// <summary>
        /// 选择排序，改变原数组排列结构
        /// </summary>
        /// <param name="iArray">待排序数组</param>
        /// <returns></returns>
        public static int[] SelectSortArray(int[] iArray)
        {
            int temp = 0;
            int i = 0;
            while (i < iArray.Length - 1)
            {
                int smallest = iArray[i];
                int smallestIndex = i;
                for (int j = i + 1; j < iArray.Length; j++)
                {
                    if (smallest > iArray[j])
                    {
                        smallest = iArray[j];
                        smallestIndex = j;
                    }
                }
                temp = iArray[i];
                iArray[smallestIndex] = temp;
                iArray[i] = smallest;
                i++;
            }
            return iArray;
        }

        public static void CountDown(int number)
        {
            if (number <= 0) return;
            else
            {
                Console.WriteLine(number);
                CountDown(number - 1);
            }
        }

        public static int Factorial(int inumber)
        {
            if (inumber <= 0) return 1;
            else return inumber * Factorial(inumber - 1);
        }

        private static void move(string x, string y)
        {
            Console.WriteLine("{0}===>{1}", x, y);
        }

        /// <summary>
        /// 汉诺塔递归
        /// </summary>
        /// <param name="dishCount">圆盘数</param>
        /// <param name="a">A柱</param>
        /// <param name="b">B柱</param>
        /// <param name="c">C柱</param>
        public static void HanoiTower(int dishCount, string a, string b, string c)
        {
            if (dishCount == 1)
            {
                move(a, c);
            }
            else
            {
                //将A柱上的n-1个盘子借助C柱移向B柱
                HanoiTower(dishCount - 1, a, c, b);
                //将A柱上仅剩的最后一个盘子移向C柱
                move(a, c);
                //将B柱上的n-1个盘子借助A柱移向C柱
                HanoiTower(dishCount - 1, b, a, c);
            }
        }

        /// <summary>
        /// 递归求数组之和
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static int RecursiveSum(List<int> args)
        {
            if (args.Count == 0)
            {
                return 0;
            }
            else
            {
                int currentEle = args[0];
                args.RemoveAt(0);
                //删除匹配的第一个元素
                //args.Remove(0);
                return currentEle + RecursiveSum(args);
            }
        }

        /// <summary>
        /// 递归获取List最大值
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static int RecursiveMax(List<int> args)
        {
            if (args.Count == 0)
                return 0;
            if (args.Count == 1)
                return args[0];
            else
            {
                int currentItem = args[0];
                args.RemoveAt(0);
                int sub_max=RecursiveMax(args);
                return currentItem > sub_max ? currentItem : sub_max;
            }
        }

        /// <summary>
        /// 快速排序
        /// </summary>
        /// <param name="args">待排序数组</param>
        /// <returns></returns>
        public static List<int> QuickSort(List<int> args)
        {
            if (args.Count < 2)
            {
                return args;
            }
            int pivot = args[0];
            //移除基准值
            args.RemoveAt(0);

            List<int> less = new List<int>(),//小于基准值的区间
                      greater = new List<int>(),//大于基准值的区间
                      result =new List<int>();//结果区间
            foreach (int item in args)
            {
                if (pivot >= item)
                    less.Add(item);
                else
                    greater.Add(item);
            }

            result.AddRange(QuickSort(less));
            result.Add(pivot);
            result.AddRange(QuickSort(greater));
            return result;
        }
    }
}
