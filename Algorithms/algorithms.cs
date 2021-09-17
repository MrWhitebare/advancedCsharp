using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
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
        public static int BinarySearch(int[]orderList,int desValue)
        {
            int low = 0;
            int high = orderList.Length - 1;
            while (low<=high)
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
        private static int[] RemoveListItem(int[] iArray,int index)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < iArray.Length; i++)
            {
                if (i != index)
                {
                    arrayList.Add(Convert.ToInt32(iArray[i]));
                }
                else continue;
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
            int[] newArray=new int[iArray.Length];
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
                for(int j=i+1; j < iArray.Length; j++)
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
    }
}
