using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Assignment2_Fall2020
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Question 1");
            int n = 7;
            PrintPatternAnyComplexity(n);
            PrintPatternLinearComplexity(n);


            Console.WriteLine("Question 2");
            int[] array1 = new int[] { 1, 3, 5, 4, 7 };
            int result = LongestSubSeq(array1);
            Console.WriteLine(result);

            Console.WriteLine("Question 3");
            int[] array2 = new int[] { 1, 2, 3, 4, 5, 5 };
            PrintTwoParts(array2);
            Console.WriteLine("");


            Console.WriteLine("Question 4");
            int[] array3 = new int[] { -4, -1, 0, 3, 10 };
            int[] result2 = SortedSquares(array3);
            Console.WriteLine("Array numbers entered");
            for(int i = 0; i < array3.Length; i++) 
                Console.Write(array3[i] + " ");
            SortedSquares(array3);
            Console.WriteLine("");
            Console.WriteLine("squaring and sort ascending");
            for (int i = 0; i < array3.Length; i++)
                Console.Write(array3[i] + " ");
            Console.WriteLine("");

            Console.WriteLine("Question 5");
            int[] nums1 = { 4, 2, 2, 4 };
            int[] nums2 = { 2, 2 };
            int[] intersect1 = Intersect(nums1, nums2);
            for (int i = 0; i < intersect1.Length; i++)
                Console.Write(intersect1[i] + " ");
            Console.WriteLine("");


            Console.WriteLine("Question 6");
            int[] arr = new int[] { 1, 2, 2, 1, 1, 3 };
            Console.WriteLine(UniqueOccurrences(arr));

            Console.WriteLine("Question 7");
            int[] numbers = { 0, 1, 3, 50, 75 };
            int lower = 0;
            int upper = 99;
            //List<String> ResultList = Ranges(numbers, lower, upper);
            Console.WriteLine(result);

            Console.WriteLine("Question 8");
            string[] names = new string[] { "pes", "fifa", "gta", "pes(2019)" };
            string[] namesResult = UniqFolderNames(names);
            for (int i = 0; i < namesResult.Length; i++)
                Console.Write(namesResult[i] + " ");
            Console.WriteLine(" ");


        }

        public static void PrintPatternAnyComplexity(int n)

        {
            try
            {
                for (int i = 1; i <= n; i++)
                {
                    string stars = new String('*', i);
                    Console.WriteLine(stars + "\n");
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static void PrintPatternLinearComplexity(int n)

        {
            try
            {
                for (int i = 1; i <= n; i++)
                {
                    string stars = new String('*', i);
                    Console.WriteLine(stars + "\n");
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static int LongestSubSeq(int[] nums)
        {
            try
            {
                int length = nums.Length;
                int longestSubSeq = 1;
                int prevLongestSubSeq = 1;
                for (int i = 0; i < (length - 1); i++)
                {
                    //update count if conditions validates
                    if (nums[i] < nums[i + 1])
                    {
                        longestSubSeq++;
                    }
                    else
                    {
                        prevLongestSubSeq = longestSubSeq;
                        longestSubSeq = 1;
                    }
                }
                //return longestSubSequence
                return (longestSubSeq > prevLongestSubSeq) ? longestSubSeq : prevLongestSubSeq;
            }
            catch (Exception)
            {

                throw;
            }
            return 0;
        }
        public static int breakstop(int[] array2)

        {
            int sumofLeft = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                sumofLeft += array2[i];
                int sumofRight = 0;
                for (int j = i + 1; j < array2.Length; j++) sumofRight += array2[j];
                if (sumofLeft == sumofRight) return i + 1;
            }
            return -1;
        }
        public static void PrintTwoParts(int[] array2)
        {            
            int split = breakstop(array2);
            try
            {
                for (int i = 0; i < array2.Length; i++)

                {
                    if (split == i) Console.WriteLine();
                    Console.Write(array2[i] + " ");
                }
            }
            catch (Exception)
            {

                if (split == -1 || split == array2.Length)

                {

                    Console.Write("Can't sum the two array into two subarrays so they add up to equal the same");

                    return;

                }
            }

        }
        public static int[] SortedSquares(int[] A)
        {
            try
            {
                int n = A.Length;

                for (int i = 0; i < n-1; i++) A[i] = A[i] * A[i];

                Array.Sort(A);
            }
            catch (Exception)
            {

                throw;
            }
            return null;
        }
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            try
            {
                var set = new HashSet<int>();
                var intersect = new HashSet<int>();

                foreach (var val in nums1)
                {
                    set.Add(val);
                }

                foreach (var val in nums2)
                {
                    if (set.Contains(val))
                    {
                        intersect.Add(val);
                    }
                }


                return intersect.ToArray();
            }
            catch
            {
                throw;
            }

            return new int[] { };
        }
        public static bool UniqueOccurrences(int[] arr)
        {
            try
            {
                var dict = new Dictionary<int, int>();
                foreach (var num in arr)
                {
                    if (!dict.ContainsKey(num)) dict[num] = 0;
                    dict[num]++;
                }

                var hashSet = new HashSet<int>();
                foreach (var freq in dict.Values)
                {
                    if (hashSet.Contains(freq)) return false;
                    hashSet.Add(freq);
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
            return default;
        }
        public List<String> Ranges(int[] numbers, int lower, int upper)
        {
            try
            {
                List<string> result = new List<string>();
                for (int i = 0; i < numbers.Length; i++)
                {
                    int start = lower;
                    while (i < numbers.Length - 1 && (numbers[i]==numbers[i+1]))
                    {
                        i++;
                    }

                    if (start != lower)
                    {
                        result.Add(string.Format("{0}->{1}", start, numbers[i]));
                    }
                    else
                    {
                        result.Add(start.ToString());
                    }
                }
                
                return result;
            }
            catch (Exception)
            {

                throw;
            }
            return default;
        }
        public static string[] UniqFolderNames(string[] names)
        {
            try
            {
                string[] result = new string[names.Length];
                Dictionary<string, int> number = new Dictionary<string, int>();
                string faux;
                int n;

                for (int i = 0; i < names.Length; i++)
                {
                    if (number.ContainsKey(names[i]))
                    {
                        n = number[names[i]];
                        faux = names[i] + "(" + n + ")";
                        while (number.ContainsKey(faux))
                        {
                            n++;
                            faux = names[i] + "(" + n + ")";
                        }
                        result[i] = faux;
                        number[faux] = 1;
                        number[names[i]] = n + 1;
                    }
                    else
                    {
                        result[i] = names[i];
                        number[names[i]] = 1;
                    }
                }

                return result;

            }
            catch (Exception)
            {

                throw;
            }
            return default;
        }

    }
}





