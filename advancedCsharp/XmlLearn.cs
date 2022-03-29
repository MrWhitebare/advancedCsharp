using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace advancedCsharp
{
    class XmlLearn
    {
        /// <summary>
        /// XML文件路径
        /// </summary>
        static string filePath = @"../xml.xml";
        /// <summary>
        /// xml对象
        /// </summary>
        static XmlDocument xml;
        /// <summary>
        /// ID结点
        /// </summary>
        static XmlNode IDnote;
        /// <summary>
        /// jobs结点
        /// </summary>
        static XmlNode jobsNode;

        //public static void InitXmlDoc()
        //{
        //    xml = new XmlDocument();
        //    XmlReaderSettings settings = new XmlReaderSettings();
        //    //忽略注释
        //    settings.IgnoreComments = true;
        //    //设置读取规则
        //    XmlReader reader = XmlReader.Create(filePath,settings);

        //    //读取XmlReader缓存
        //    xml.Load(reader);
        //    reader.Close();

        //    IDnote = xml.SelectSingleNode("/note/ID");
        //    jobsNode = xml.SelectSingleNode("/note/jobs");

        //    XmlAttributeCollection attributes = IDnote.Attributes;
        //    foreach (XmlNode node in attributes)
        //        Print("Attributes",node.Value);
        //}
        //public static void Main(string[] args)
        //{
        //    InitXmlDoc();
        //    Console.ReadKey();
        //}

        public static void Print(string str,object obj)
        {
            Console.WriteLine("{0}： {1}", str, obj);
            Console.WriteLine("------------------------------");
        }
    }
}
