using System;
using System.Reflection;

namespace advancedCsharp
{
    public class CustomAttribute
    {
        public static void Main(string[] args)
        {
            //使用反射技术读取Attribute
            MemberInfo info = typeof(Student);
            HobbyAttribute hobbyAttribute = (HobbyAttribute)Attribute.GetCustomAttribute(info, typeof(HobbyAttribute));
            if (hobbyAttribute != null)
            {
                Console.WriteLine($"类名:{info.Name}");
                Console.WriteLine($"兴趣类型:{hobbyAttribute.Type}");
                Console.WriteLine($"兴趣指数:{hobbyAttribute.Level}");
                Console.ReadKey();
            }
        }
       
    }

    [Hobby("Sports",-5)]
    class Student
    {
        [Hobby("Football",4)]
        private string profession;
        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }
    }

    class HobbyAttribute : Attribute
    {
        //兴趣类型
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; } 
        } 

        public HobbyAttribute(string _type,int _level)
        {
            this.type = _type;
            this.level = _level;
        }

        //兴趣指数
        private int level;
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
    }
}
