using System;

namespace NoviceChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testarray = {1,2,3,4,5,6,7,8};
            char test = 'c';
            Console.WriteLine(SwapEnds("Frankfurt"));
        }

        // 1. Return the sum of two numbers.
        public static int Add(int a, int b)
        {
            int sum = a + b;

            return sum;
        }

        // 2. Given an integer, return true if it's even, else return false.
        public static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            } else {
                return false;
            }
            
        }

        // 3. Return the largest of three numbers.
        public static int MaxOfThree(int a, int b, int c)
        {
            int largest = Math.Max(a, Math.Max(b,c));
            return largest;
        }

        // 4. Return the length of the given string.
        public static int StringLength(string s)
        {
            return s.Length;
        }

        // 5. Return true if the string starts with "Hello", otherwise return false.
        public static bool StartsHello(string s)
        {
            if (s.StartsWith("Hello")||s.StartsWith("hello"))
            {
                return true;
            } else {
                return false;
            }
        }

        // 6. Reverse a given string.
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            string reverse = "";
            
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                reverse += charArray[i];
            }

            return new string(reverse);
        }

        // 7. Return the factorial of a number.
        public static int Factorial(int n)
        {
            int answer = 1; 

            for (int i = 1; i <= n; i++)
            {
                answer = answer * i;
            }
            return answer;
        }

        // 8. Check if a number is a prime number.
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;

            int a = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0) 
                a++;
            }

            if(a == 2)
            {
                return true;
            } else {
                return false;
            }
        }

        // 9. Return the nth Fibonacci number.
        public static int Fibonacci(int n)
        {
            if (n <= 1) return n;
            int num1 = 0;
            int num2 = 1;
            int answer = 0;
            
            for (int i = 2; i < n + 1; i++)
            {
                answer = num1 + num2;
                num1 = num2;
                num2 = answer;
            }

            return answer;
        }

        // 10. Given an array of integers, return the largest number.
        public static int LargestInArray(int[] numbers)
        {
            int largest = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                int temp = numbers[i];
                if(largest < temp)
                {
                    largest = temp;
                    
                } 
            }
            return largest;
        }

        // 11. Check if a string is a palindrome (reads the same forward and backward).
        public static bool IsPalindrome(string s)
        {

            char[] charArray = s.ToCharArray();
            string reverse = "";
            
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                reverse += charArray[i];
            }

            if (reverse.ToLower() == s.ToLower())
            {
                return true;
            } else {
                return false;
            }
        }

        // 12. Given an array of integers, return the sum of its elements.
        public static int ArraySum(int[] numbers)
        {
            int sum = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        // 13. Given a string, count how many times a specified character appears in it.
        public static int CharCount(string s, char c)
        {
            int count = 0;
            
            string lower = s.ToLower();

            for (int i = 0; i < lower.Length; i++)
            {
                if (lower[i] == c)
                {
                    count++;
                }
            }

            return count;
        }

        // 14. Given two strings, return a new string that is the concatenation of the two strings with a space in between.
        public static string ConcatenateStrings(string str1, string str2)
        {
            string twoString = str1 + " " + str2;
            return twoString;
        }

        // 15. Given a string, return a new string where the first and last characters have been swapped.
        public static string SwapEnds(string s)
        {
            if (s.Length <= 1) return s;
            
            char firstChar = s[0];
            char lastChar = s[s.Length - 1];

            char[] charArray = s.ToCharArray();
            char[] swappedArray = new char[s.Length];
    
            swappedArray[0] = lastChar;

            for (int i = 1; i < s.Length; i++)
            {
                Console.WriteLine(swappedArray);
                swappedArray[i] += charArray[i];
            }

            swappedArray[s.Length - 1] = firstChar;

            string answer = new string(swappedArray);

            return answer;
        }
    }
}
