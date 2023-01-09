using System;
using System.Text;

namespace Sample_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine();
            Console.WriteLine("Reverse words order in a sentence");
            Console.WriteLine(ReverseWordsOrderInSentence(sentence));
            Console.WriteLine("Reverse each word in a sentence");
            Console.WriteLine(ReverseEachWordInSentence(sentence));
        }
        public static string ReverseWordsOrderInSentence(string sentence)
        {
            string[] words = sentence.Split(' ');
            StringBuilder reverseSentence = new StringBuilder();

            for(int i=words.Length-1; i>=0;i--)
            {
                if (i != 0)
                    reverseSentence.Append(words[i] + " ");
                else
                    reverseSentence.Append(words[i]);
            }
            return reverseSentence.ToString();
        }

        public static string ReverseEachWordInSentence(string sentence)
        {
            StringBuilder result = new StringBuilder();
            string[] words = sentence.Split(' ');
            for(int i=0;i<words.Length;i++)
            {
                if (i != words.Length - 1)
                    result.Append(ReverseWord(words[i]) + " ");
                else
                    result.Append(ReverseWord(words[i]));
            }
            return result.ToString();
        }

        public static string ReverseWord(string sentence)
        {
            char[] charArray = sentence.ToCharArray();
            StringBuilder result = new StringBuilder();
            for(int i=charArray.Length-1;i>=0;i--)
            {
                result.Append(charArray[i]);
            }
            return result.ToString();
        }
    }
}
