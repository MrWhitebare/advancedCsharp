using System;
using System.Collections.Generic;
using System.Text;

namespace advancedCsharp
{
    delegate int NumberChanger(int n);
    class delegateUse
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

        /*static void Main(string[] args)
        {
            //创建委托实例
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);
            //使用委托调用方法
            nc1(25);
            Console.WriteLine("Value of Num: {0}", getNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }*/
    }

    class delegateMultiUse
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

        /*static void Main(string[] args)
        {
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);
            nc = nc1;
            nc += nc2;
            //调用多播
            nc(5);
            Console.WriteLine("Value of Num :{0}", getNum());
            Console.ReadKey();
        }*/
    }
}
