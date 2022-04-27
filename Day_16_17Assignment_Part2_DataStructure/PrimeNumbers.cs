using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_16_17Assignment_Part2_DataStructure
{
    internal class PrimeNumbers
    {
        /// <summary>
        /// Checking that number is Prime or not
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        static bool[,] arr = new bool[10, 100];
        public static bool isPrime(int no)
        {
            int prime = 0;

            if (no == 0 || no == 1)
            {
                return false;
            }
            if (no == 2)
            {
                return true;
            }
            else
            {
                for (int i = 2; i <no; i++)
                {
                    if ((no % i) == 0)
                    {
                        prime = 0;
                        break;
                    }
                    else
                    {
                        prime = 1;
                    }
                }

                if (prime == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool isAnagram(string s1, string s2)
        {
            char[] str1 = s1.ToCharArray(); // Storing the string letter in character array
            char[] str2 = s2.ToCharArray(); // Storing the string letter in character array
            Array.Sort(str1); // Sorting string 1 array
            Array.Sort(str2); // Sorting string 2 array
            if (str1.Length != str2.Length) //Checking that length of both string is equal or not
            {
                return false;
            }
            for (int i = 0; i<str1.Length; i++) // Comparing all the character one by one in both strings
            {
                if (str1[i] != str2[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static bool[,] PrimeNumbersInRange()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = isPrime(i*100+j+1);
                }
            }
            return arr;
        }
        public static bool[,] AnagramPrimeNumbersInRange()
        {
            bool[,] a = new bool[10, 100];
            string n1, n2;
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j])
                    {
                        for (int m = 0; m < arr.GetLength(0); m++)
                        {
                            for (int n = 0; n < arr.GetLength(1); n++)
                            {
                                if (i != m || j != n)
                                {
                                    if (arr[m, n])
                                    {
                                        n1 = (i*100+j+1).ToString();
                                        n2 = (m*100+n+1).ToString();
                                        if (n1.Length == n2.Length && n1.Length != 1)
                                        {
                                            bool check = isAnagram(n1, n2);
                                            if (check)
                                            {
                                                a[i, j] = check;
                                                a[m, n] = check;
                                            }
                                                
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }          
            return a;
        }      
        public static void Display(bool[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.WriteLine("\n\nAll Prime numbers in "+(i*100) + " - "+(i+1)*100 + "range\n");
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j])
                    {
                        Console.Write(i*100+j+1+" ");
                    }
                }
            }
        }        
        public static void PrimeNumbersInStack()
        {
            CustomLinkedList<int> list = new CustomLinkedList<int>();
            int[] primeNumbers = new int[168];
            int j = 0;
            for(int i = 0; i <= 1000; i++)
            {
                if(isPrime(i))
                {
                    primeNumbers[j] = i;
                    j++;
                }
            }
            for(int k = 0; k < primeNumbers.Length; k++)
            {
                for (int l = 0; l < primeNumbers.Length; l++)
                {
                    string s1 = primeNumbers[k].ToString();
                    string s2 = primeNumbers[l].ToString();
                    if (k!=l && s1.Length == s2.Length)
                    {
                        bool r = isAnagram(s1,s2);
                        if(r)
                        {
                            list.Append(primeNumbers[l]);
                        }
                    }
                }
            }
            list.DisplayElement();
        }
        public static void PrimeNumbersInQueue()
        {
            CustomLinkedList<int> list = new CustomLinkedList<int>();
            int[] primeNumbers = new int[168];
            int j = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if (isPrime(i))
                {
                    primeNumbers[j] = i;
                    j++;
                }
            }
            for (int k = 0; k < primeNumbers.Length; k++)
            {
                for (int l = 0; l < primeNumbers.Length; l++)
                {
                    string s1 = primeNumbers[k].ToString();
                    string s2 = primeNumbers[l].ToString();
                    if (k!=l && s1.Length == s2.Length)
                    {
                        bool r = isAnagram(s1, s2);
                        if (r)
                        {
                            list.Append(primeNumbers[l]);
                        }
                    }
                }
            }
            list.DisplayElement();
        }
    }
}
