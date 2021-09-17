using System;
using System.Collections.Generic;
using System.Text;

namespace advancedCsharp
{
    public class UseGeneric<T>
    {
        private T[] array;
        public T[] Array
        {
            get
            {
                return array;
            }
            set
            {
                array = value;
            }
        }
        public UseGeneric(int size)
        {
            Array = new T[size + 1];
        }
        public T getItem(int index)
        {
            return Array[index];
        }
        public void setItem(int index, T value)
        {
            Array[index] = value;
        }
    }
    class Program
    {
       /* public static void Main(string[] args)
        {
            UseGeneric<int> iuseGeneric = new UseGeneric<int>(5);
            //赋值
            for (int j = 0; j < iuseGeneric.Array.Length; j++)
            {
                iuseGeneric.setItem(j, j * 5);
            }
            //获取值
            int i = 0;
            while (i< iuseGeneric.Array.Length)
            {
                Console.Write(iuseGeneric.getItem(i) + "\t");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("====={0}======","分割线");

            UseGeneric<char> charArray = new UseGeneric<char>(5);
            // 设置值
            for (int c = 0; c < 5; c++)
            {
                charArray.setItem(c, (char)(c + 97));
            }
            // 获取值
            for (int c = 0; c < 5; c++)
            {
                Console.Write(charArray.getItem(c) + "\t");
            }
        }*/
    }
}
