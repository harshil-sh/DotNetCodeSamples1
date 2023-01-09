using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to reverse");
            string str = Console.ReadLine();
            
            Console.WriteLine(ReverseString(str));
        }
        public static string ReverseString(string str)
        {
            int startIndex = 0;
            int endIndex = str.Length - 1;
            char[] charArray = str.ToCharArray();
            for (int i = startIndex, j = endIndex; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            return new string(charArray);
        }

    }
}
