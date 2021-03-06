﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static string[] convertToStringArray(string input)
        {
            return input.Split(' ').Select(i => i).ToArray();
        }

        static int[] convertToIntArray(string input)
        {
            return input.Split(' ').Select(i => Convert.ToInt32(i)).ToArray();
            //test github
        }

        static double WeightedMean(int length, int[] weightArray, int[] respectiveWeightsArray)
        {
            double total = 0;
            double divide = 0;
            for (int i = 0; i < weightArray.Length; i++)
            {
                total = total + weightArray[i] * respectiveWeightsArray[i];
                divide = divide + respectiveWeightsArray[i];
            }
            return total / divide;
        }

        static string IntroToConditionalStatements(int number)
        {
            var result = "";
            if (number % 2 == 1)
            {
                result = "Weird";
            }
            else
            {
                if (number >= 2 && number <= 5)
                {
                    result = "Not Weird";
                }
                else if (number >= 6 && number <= 20)
                {
                    result = "Weird";
                }
                else
                {
                    result = "Not Weird";
                }
            }
            return result;
        }

        static void LetsReview(int numberOfTestCase, string[] testCases)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < numberOfTestCase; i++)
            {
                var testCaseArray = testCases[i].ToArray();
                for (int k = 0; k < testCaseArray.Length; k = k + 2)
                {
                    sb.Append(testCaseArray[k]);
                }
                sb.Append("  ");
                for (int k = 1; k < testCaseArray.Length; k = k + 2)
                {
                    sb.Append(testCaseArray[k]);
                }
                sb.AppendLine();
            }

            Console.Write(sb.ToString());
        }

        static void Main(string[] args)
        {
            #region 30 days of Code Chanllenges

            //day 1
            //int i = 4;
            //double d = 4.0;
            //string s = "HackerRank";

            //// Declare second integer, double, and String variables.
            //int secondInt; double secondDouble; string secondString;
            //// Read and save an integer, double, and String to your variables.
            //secondInt = Convert.ToInt32(Console.ReadLine());
            //secondDouble = Convert.ToDouble(Console.ReadLine());
            //secondString = Console.ReadLine();
            //// Print the sum of both integer variables on a new line.
            //Console.WriteLine(i + secondInt);
            //Console.WriteLine((d + secondDouble).ToString("0.0"));

            //Console.WriteLine(s + secondString);


            ////day 2
            //double mealPrice = Convert.ToDouble(Console.ReadLine());
            //double tipPercent = Convert.ToInt32(Console.ReadLine());
            //double taxPercent = Convert.ToInt32(Console.ReadLine());

            //var totalCost = mealPrice + mealPrice * tipPercent / 100 + mealPrice * taxPercent / 100;
            //Console.WriteLine(string.Format("The total meal cost is {0} dollars.", Math.Round(totalCost, 0)));

            //Day 3: Intro to Conditional Statements
            //Console.WriteLine(IntroToConditionalStatements(Convert.ToInt32(Console.ReadLine())));


            //Day 6: Let's Review 

            //var numberOfTestCase = Convert.ToInt32(Console.ReadLine());
            //var testCases = new List<String>();
            //string input;
            //var idx = 1;

            //input = Console.ReadLine();

            //while (input.ToUpper() != "EXIT" && idx <= numberOfTestCase)
            //{
            //    testCases.Add(input);
            //    if (idx == numberOfTestCase) { break; }
            //    idx++;
            //    input = Console.ReadLine();
            //}

            //LetsReview(numberOfTestCase, testCases.ToArray());

            //Day 7: Arrays

            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            
            for (int i = arr.Length -1; i >=0 ; i--)
            {
                Console.Write(arr[i] + " ");
            }
            #endregion



            #region 10 Days of Statistics Challenges 
            //Day 0: Weighted Mean
            var length = Convert.ToInt32(Console.ReadLine());
            var weightArray = convertToIntArray(Console.ReadLine());
            var respectiveWeightsArray = convertToIntArray(Console.ReadLine());
            Console.WriteLine(WeightedMean(length, weightArray, respectiveWeightsArray).ToString("0.0"));


            #endregion

            var sol = new Solution();
            var aaa = new int[] { 64630, 11735, 14216, 99233, 14470, 4978, 73429, 38120, 51135, 67060 };
            sol.Mean(10, aaa);
            sol.Median(10, aaa);
            //Console.WriteLine(7 / 2);
            //Kata.GetMiddle("testing");
            //Kata.rowSumOddNumbers(42);
            //var arr = new int[] { 1, 2, 3, 4, 3, 2, 1 };
            //Kata.FindEvenIndex(arr);
            //DigPow.digPow(999999, 1);
            //Accumul.Accum("ZpglnRxqenU");
            //Kata.SpinWords("This is another test");
            //Kata.palindromeChainLength(89);
            //List<int> i = new List<int> { -5, -5, 7, 7, 12, 0 };
            //Consecutives.SumConsecutives(i);
            //Kata.FirstNonRepeatingLetter("aa");
            //GapInPrimes.Gap(6, 100, 110);
            //Kata.DuplicateCount("Indivisibilities");
            //Diamond.print(3);
            //BouncingBall.bouncingBall(30.0, 0.66, 1.5);

            for (int k = 1; k <= 1000; k++)
            {
                var result = RemovedNumbers.removNb(k);


                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        Debug.WriteLine("k is {0}, item 0 is {1}, item 1 is {2}", k, item[0], item[1]);
                    }
                }
            }
        }
    }

    public class Solution
    {
        //mean median mode
        public void Mean(int n, int[] arr)
        {
            Console.WriteLine(Math.Round(arr.Average(), 1));
        }

        public void Median(int n, int[] arr)
        {
            double result;
            var newArray = arr.OrderBy(a => a).ToArray();
            if (n % 2 == 0)
            {
                var first = newArray[(n / 2) - 1];
                var second = newArray[(n / 2)];

                result = Math.Round(Convert.ToDouble((first + second) / 2.0), 1);
            }
            else
            {
                result = Math.Round(Convert.ToDouble(newArray[(n + 1) / 2]), 1);
            }
            Console.WriteLine(result);
        }

        public void Mode(int n, int[] arr)
        {
            var groups = arr.GroupBy(a => a).OrderByDescending(g => g.Count()).ThenBy(g => g.ToArray()[0]).ToArray();

            var result = groups[0].ToArray()[0];

            Console.WriteLine(Math.Round(Convert.ToDouble(result), 1));
        }
    }

    public class ToSmallest
    {
        /// <summary>
        /// Give a number, turn an array of 3
        /// </summary>
        /// <param name="number"></param>
        /// <returns>
        ///1) the smallest number you got
        ///2) the index i of the digit d you took, i as small as possible
        ///3) the index j(as small as possible) where you insert this digit d to have the smallest  
        /// </returns>
        public static long[] Smallest(long number)
        {
            var result = new long[3];
            long smallestNumber = 0;
            long indexI = 0;
            long indexJ = 0;
            //turn the number to number array
            var numberArray = number.ToString().ToArray().Select(n => int.Parse(n.ToString())).ToList();
            //find the smallest number
            var min = numberArray.Min();
            //loop through
            for (int i = 0; i < numberArray.Count; i++)
            {
                if (numberArray[i] == min)
                {
                    //if the index is NOT zero, then move the number to 0 
                    if (i >= 1) //261235
                    {
                        indexI = i;
                        indexJ = 0;
                        var numberAtIndexZero = numberArray[0];
                        numberArray[0] = numberArray[i];
                        numberArray[i] = numberAtIndexZero;
                    }
                    else //=0
                    {

                    }
                }
                else
                {
                    break;
                }
            }
            result[0] = smallestNumber;
            result[1] = indexI;
            result[2] = indexJ;
            return result;
        }
    }

    //too slow, but no idea how to improve the speed at the moment
    public class RemovedNumbers
    {
        public static List<long[]> removNb(long n)
        {
            var result = new List<long[]>();

            var sum = (1 + n) * n / 2;
            for (int i = 1; i <= n; i++)
            {
                var k = i + 1;
                while (k <= n)
                {
                    if (i * k == sum - i - k)
                    {
                        var item = new long[] { i, k };
                        var itemReverse = new long[] { k, i };
                        result.Add(item);
                        result.Add(itemReverse);
                        break;
                    }
                    k++;
                }
            }
            return result;
        }
    }

    public class BouncingBall
    {
        public static int bouncingBall(double height, double bounce, double window)
        {
            if (bounce >= 1 || bounce <= 0 || height <= 0 || height <= window)
            {
                return -1;
            }
            var times = 0;
            for (double i = height; i >= window; i = i * bounce)
            {
                times++;
                if (i * bounce > window)
                {
                    times++;
                }
            }
            return times;
        }
    }

    public class Diamond
    {
        public static string print(int n)
        {
            if (n <= 0 || n % 2 == 0)
            {
                return null;
            }

            var sb = new StringBuilder();

            for (int i = 1; i <= n; i = i + 2)
            {
                var st = new string(' ', (n - i) / 2) + new string('*', i) + new string(' ', (n - i) / 2);
                sb.AppendLine(st);
            }
            for (int i = n - 2; i >= 1; i = i - 2)
            {
                var st = new string(' ', (n - i) / 2) + new string('*', i) + new string(' ', (n - i) / 2);
                sb.AppendLine(st);
            }

            return sb.ToString();
        }
    }

    public class IQ
    {
        public static int Test(string numbers)
        {
            var arr = numbers.Split(' ').Select(n => int.Parse(n.ToString())).ToArray();

            var firstOdd = -1;
            var firstEven = -1;
            var secondOdd = -1;
            var secondEven = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    if (firstEven < 0)
                    {
                        firstEven = i;
                    }
                    else
                    {
                        secondEven = i;
                    }

                }
                else
                {
                    if (firstOdd < 0)
                    {
                        firstOdd = i;
                    }
                    else
                    {
                        secondOdd = i;
                    }
                }

                if ((firstOdd > 0 && firstEven > 0) && (secondOdd > 0 || secondEven > 0))
                {
                    break;
                }
            }

            if (secondEven > 0)
            {
                return firstOdd + 1;
            }
            else
            {
                return firstEven + 1;
            }
        }
    }

    class GapInPrimes
    {
        public static long[] Gap(int g, long m, long n)
        {
            var result = new long[2];

            //find the first pm
            var found = false;
            for (long i = m; i <= n; i++)
            {
                if (isPrime(i) && i + g <= n)
                {
                    if (isPrime(i + g))
                    {
                        var foundPrimeInBetween = false;
                        for (long k = i + 1; k < i + g; k++)
                        {
                            if (isPrime(k))
                            {
                                foundPrimeInBetween = true;
                            }
                        }
                        if (!foundPrimeInBetween)
                        {
                            result[0] = i;
                            result[1] = i + g;
                            found = true;
                            break;
                        }
                    }
                }
            }

            return found ? result : null;
        }

        public static bool isPrime(long number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }

    public class Consecutives
    {
        public static List<int> SumConsecutives(List<int> sss)
        {
            var result = new List<int>();

            var count = 0;
            var sum = 0;
            var first = sss[count];
            for (int i = 0; i < sss.Count; i++)
            {
                //if item equal first item, add to sum
                var current = sss[i];
                if (first == current)
                {
                    sum = sum + first;
                }
                if (i + 1 == sss.Count)
                {
                    result.Add(sum);
                }
                //check next one
                if (count + 1 < sss.Count)
                {
                    var second = sss[count + 1];
                    if (first != second)
                    {
                        first = second;
                        result.Add(sum);
                        sum = 0;
                    }
                }

                count++;
            }

            return result;
        }

        public static List<int> SumConsecutivesRecursive(List<int> sss)
        {
            var result = new List<int>();

            if (sss.Count == 1)
            {
                result = new List<int>() { sss[0] };
            }
            else
            {
                result.Add(GetSumConsecutive(sss, sss[0]));
            }
            return result;
        }

        public static int SumConsecutivesReturnInt(List<int> sss)
        {
            if (sss.Count == 1)
            {
                return sss[0];
            }
            else
            {
                var sum = 0;
                var first = sss[0];
                for (int i = 0; i < sss.Count; i++)
                {
                    if (sss[i] == first)
                    {
                        sum = sum + first;
                    }
                    else
                    {
                        break;
                    }
                }
                return sum;
            }
        }

        public static int GetSumConsecutive(List<int> sss, int start)
        {
            if (sss.Count == 1)
            {
                return sss[0];
            }

            var sum = 0;
            var count = 0;

            for (int i = 0; i < sss.Count; i++)
            {
                if (start == sss[i])
                {
                    sum = sum + sss[i];
                }
                else
                {
                    count = 1;
                    break;
                }
            }

            //means sss is not running out
            if (count < sss.Count - 1)
            {
                var result = GetSumConsecutive(sss.Skip(count).ToList(), count);
            }

            return sum;
        }
    }

    public class Accumul
    {
        public static String Accum(string s)
        {

            var charArray = s.Select(ss => ss).ToArray();
            var sb = new StringBuilder();

            for (int i = 0; i < charArray.Length; i++)
            {
                sb.Append(charArray[i].ToString().ToUpper());

                for (int k = 0; k < i; k++)
                {
                    sb.Append(charArray[i].ToString().ToLower());
                }
                if (i < charArray.Length - 1)
                {
                    sb.Append("-");
                }
            }

            return sb.ToString();
        }
    }

    public class DigPow
    {
        public static long digPow(int n, int p)
        {
            long result = -1;
            //split the para
            var inteArray = n.ToString().Select(i => double.Parse(i.ToString())).ToArray();
            double sum = 0;
            var tempP = p;
            for (int i = 0; i < inteArray.Length; i++)
            {
                sum = sum + Math.Pow(inteArray[i], tempP);
                tempP++;
            }

            var temp = sum / n;

            if (Math.Truncate(temp) == temp)
            {
                result = (long)temp;
            }

            return result;
        }
    }

    public class Kata
    {

        public static int DuplicateCount(string str)
        {
            var result = str.ToLower().ToArray().GroupBy(s => s).Where(g => g.ToArray().Length > 1).Count();
            return result;
        }

        public static string FirstNonRepeatingLetter(string str)
        {
            var strArray = str.ToArray();
            var group = strArray.GroupBy(s => s.ToString());
            if (group.All(s => s.ToArray().Length > 1))
            {
                return "";
            }
            var result = "";
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray.Count(s => s.ToString().ToLower() == strArray[i].ToString().ToLower()) == 1)
                {
                    result = strArray[i].ToString();
                    break;
                }
            }

            return result;

        }

        public static int palindromeChainLength(int n)
        {
            if (checkIfPalindrome(n))
            {
                return 0;
            }
            var result = parlindromeRecurize(n, 1);
            return result;
        }

        public static int parlindromeRecurize(long n, int level)
        {
            //find the palindrome
            long sum = 0;
            var rn = reverseNumber(n);
            //add 
            sum = n + rn;

            //if sum is not a palindrome - keep doing
            if (!checkIfPalindrome(sum))
            {
                level++;
                return parlindromeRecurize(sum, level);
            }
            else
            {
                //otherwise return the level number
                return level;
            }
        }

        public static long reverseNumber(long n)
        {
            return long.Parse(new string(n.ToString().Reverse().ToArray()));
        }

        /// <summary>
        /// get palindrome if exist or -1
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool checkIfPalindrome(long n)
        {
            var numberReverse = reverseNumber(n);
            return n == numberReverse;
        }

        public static string SpinWords(string sentence)
        {
            return string.Join(" ", sentence.Split(' ').Select(s => s.Length >= 5 ? new string(s.Reverse().ToArray()) : s).ToArray());
        }

        public static int FindEvenIndex(int[] arr)
        {
            var result = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                var left = arr.Take(i).ToArray();//.Sum();
                var right = arr.Skip(i + 1).Take(arr.Length - i).ToArray();//.Sum();
                if (left.Sum() == right.Sum())
                {
                    result = i;
                    break;
                }
            }

            return result;
        }

        public static long rowSumOddNumbers(long n)
        {
            long result;

            //first find the row and build a array with row number
            var ar = new long[n];

            //array starting the number with row number multi by row number - 1
            ar[0] = 1 + n * (n - 1);
            for (int i = 1; i < ar.Length; i++)
            {
                ar[i] = ar[0] + i * 2;
            }
            result = ar.Sum();
            return result;
        }

        public static string GetMiddle(string s)
        {
            var result = "";

            //get the length
            var stringLength = s.Length;

            if (stringLength <= 2)
            {
                result = s;
            }
            else
            {

                //check if odd or even
                if (stringLength % 2 == 1)
                {
                    result = s.ToArray()[stringLength / 2].ToString();
                }
                else
                //if odd take middle 
                {
                    result = s.ToArray()[stringLength / 2 - 1].ToString() + s.ToArray()[(stringLength / 2)].ToString();
                }

            }
            return result;
        }
    }
}
