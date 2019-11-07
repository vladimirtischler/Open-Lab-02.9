using System;

namespace Open_Lab_02._9
{
    class Program
    {
        public static string ConcatName(string name1, string name2)
        {
            return ($"{name1}, {name2}");
        }
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            Console.WriteLine(ConcatName(str1, str2));
        }
    }
}
