using System;
using System.Collections.Generic;
using System.Text;

namespace advancedCsharp
{
    public delegate T NumberChanger<T>(T n);
    class GenericDelegate
    {
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        /*public static void Main(string[] args)
        {
            NumberChanger<int> numberChanger1 = new NumberChanger<int>(AddNum);
            NumberChanger<int> numberChanger2 = new NumberChanger<int>(MultNum);
            // 使用委托对象调用方法
            numberChanger1(25);
            Console.WriteLine("Value of Num: {0}", getNum());
            numberChanger2(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }*/
    }
}
