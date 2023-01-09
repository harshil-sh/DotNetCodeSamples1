using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (IsPrimeNumber(number))
                Console.WriteLine("Prime Number");
            else
                Console.WriteLine("Not a Prime Number");
            Console.WriteLine("Find second largest Number in an array");
            Console.WriteLine("Enter a int array limit");
            int sizeOfArray = Convert.ToInt32(Console.ReadLine());
            if (sizeOfArray > 2)
            {
                int[] arr = new int[sizeOfArray];
                Console.WriteLine("Inputs of the array");
                for (int i = 0; i < sizeOfArray; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Second largest element is: " + FindSecondLargestNumber(arr));
            }
            else
                Console.WriteLine("Please enter atleast size greater than 2");
            
        }


        public static bool IsPrimeNumber(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if ((number % 2) == 0) return false;
            var squareroot = (int)Math.Sqrt(number);
            for (int i = 3; i <= squareroot; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public static int FindSecondLargestNumber(int[] arr)
        {
            int large = 0;
            int secondLarge = 0;
            int i, j = 0;
            int sizeOfArray = arr.Length;
            //Find the largest number
            for (i = 0; i < sizeOfArray; i++)
            {
                if (large < arr[i])
                {
                    large = arr[i];
                    j = i;
                }
            }
            // ignore largest number and find second largest Number
            for (i = 0; i < arr.Length; i++)
            {
                if (i != j)
                {
                    if (secondLarge < arr[i])
                    {
                        secondLarge = arr[i];
                    }
                }
            }
            return secondLarge;
        }
    }
}
