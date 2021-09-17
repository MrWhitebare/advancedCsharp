using System;
using System.Collections.Generic;
using System.Text;

namespace advancedCsharp
{
    /// <summary>
    /// 重载索引器
    /// </summary>
    class IndexerNames
    {
        public static int size = 10;
        private string[] namelist = new string[size];
        public IndexerNames(){
            for (int i = 0; i < size; i++)
            {
                namelist[i] = "N. A.";
            }
        }

        /// <summary>
        /// 键入元素
        /// </summary>
        /// <param name="index">元素序号</param>
        /// <returns></returns>
        public string this [int index]
        {
            get
            {
                string tmp;
                if (index >= 0 && index <= size - 1)
                {
                    tmp = namelist[index];
                }
                else
                {
                    tmp = "";
                }
                return tmp;
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    namelist[index] = value;
                }
            }
        }

        /// <summary>
        /// 获取索引
        /// </summary>
        /// <param name="name">名称</param>
        /// <returns></returns>
        public int this [string name]
        {
            get
            {
                int index = 0;
                while (index<size)
                {
                    if (namelist[index] == name)
                    {
                        return index;
                    }
                    index++;
                }
                return index;
            }
        }
    }

    class Indexer
    {
        public static int size = 10; 
        private string[] namelist = new string[size];
        public Indexer()
        {
            for (int i = 0; i < size; i++)
            {
                namelist[i] = "N. A. ";
            }
        }

        public string this[int index]
        {
            get
            {
                string tmp;
                if (index >= 0 && index <= size-1)
                {
                    tmp = namelist[index];
                }
                else
                {
                    tmp = "";
                }
                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    namelist[index] = value;
                }
            }
        }

/*        static void Main(string[] args)
        {
            //indexer indexername = new indexer();
            IndexerNames indexerName = new IndexerNames();
            indexerName[0] = "Zara";
            indexerName[1] = "Riz";
            indexerName[2] = "Nuha";
            indexerName[3] = "Asif";
            indexerName[4] = "Davinder";
            indexerName[5] = "Sunil";
            indexerName[6] = "Rubic";

            for (int i = 0; i < Indexer.size; i++)
            {
                Console.WriteLine(indexerName[i]);
            }
            Console.WriteLine(indexerName["Riz1"]);
            Console.ReadKey();
        }*/
    }
}