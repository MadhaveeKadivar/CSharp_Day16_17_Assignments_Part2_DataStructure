using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_16_17Assignment_Part2_DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*****Day 16/17 Data Structure Part********");
            Console.WriteLine("\nProblem - 1 UnOrdered Linked List");
            Console.WriteLine("\nProblem - 2 Ordered Linked List");
            Console.WriteLine("\nProblem - 3 Balanced Parentheses Checker using Stack");
            Console.WriteLine("\nProblem - 5 Palindrome Checker using Queue");
            Console.WriteLine("\nProblem - 6 Hashing Function to search a Number in a slot");
            Console.WriteLine("\nProblem - 8 Store Prime numbers in 2D Array");
            Console.WriteLine("\nProblem - 9 Store Prime numbers in 2D Array which are anagram");
            Console.WriteLine("\nProblem - 10 Store Prime numbers in stack which are anagram");
            Console.WriteLine("\n\nEnter any choice");
            int c = Convert.ToInt32(Console.ReadLine());

            switch(c)
            {
                //Unordered List
                case 1:
                    CustomLinkedList<string> unorderedList = new CustomLinkedList<string>();
                    string word;
                    while (true)
                    {
                        Console.WriteLine("\n\n1.Do you want add any word in Linked List");
                        Console.WriteLine("2.Do you want search any word in Linked List and If found then remove it otherwise add it to Linked List");                       
                        Console.WriteLine("3.Exit");
                        Console.WriteLine("\nEnter any choice");
                        int ch = Convert.ToInt32(Console.ReadLine());
                        switch (ch)
                        {
                            case 1:
                                Console.WriteLine("\nEnter any word : ");
                                word = Console.ReadLine();
                                unorderedList.Append(word);
                                unorderedList.DisplayElement();
                                break;
                            case 2:
                                Console.WriteLine("\nEnter any word you want to search :");
                                word = Console.ReadLine();
                                bool check = unorderedList.Search(word);
                                if (check)
                                {
                                    unorderedList.Remove(word);
                                }
                                else
                                {
                                    unorderedList.Append(word);
                                }
                                unorderedList.DisplayElement();
                                break;
                            case 3:
                                System.Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("\nEnter valid choice");
                                break;
                        }
                    }
                 // Ordered List
                case 2:
                    CustomLinkedList<int> orderedList = new CustomLinkedList<int>();
                    int number;
                    while (true)
                    {
                        Console.WriteLine("\n\n1.Do you want add any number in Linked List");
                        Console.WriteLine("2.Do you want search any number in Linked List and If found then remove it otherwise add it to Linked List");
                        Console.WriteLine("3.Exit");
                        Console.WriteLine("\nEnter any choice");
                        int ch = Convert.ToInt32(Console.ReadLine());
                        switch (ch)
                        {
                            case 1:
                                Console.WriteLine("\nEnter any number : ");
                                number = Convert.ToInt32(Console.ReadLine());
                                orderedList.AddWithAcsendingOrder(number);
                                orderedList.DisplayElement();
                                break;
                            case 2:
                                Console.WriteLine("\nEnter any number you want to search :");
                                number = Convert.ToInt32(Console.ReadLine());
                                bool check = orderedList.Search(number);
                                if (check)
                                {
                                    orderedList.Remove(number);
                                }
                                else
                                {
                                    orderedList.AddWithAcsendingOrder(number);
                                }
                                orderedList.DisplayElement();
                                break;
                            case 3:
                                System.Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("\nEnter valid choice");
                                break;
                        }
                    }
                //Balanced Parentheses Checker using Stack
                case 3:
                    Console.WriteLine("\n\nEnter any Arithmetic Expression: \n");
                    string expression = Console.ReadLine();
                    BalancedParenthesesCheckerByStack checkParentheses= new BalancedParenthesesCheckerByStack();
                    checkParentheses.ParenthesesChecker(expression);
                    break;
                //Palindrome Checker using Queue
                case 5:
                    Console.WriteLine("\nEnter any word or Sentence : ");
                    string s = Console.ReadLine();
                    PalindromeCheckerUsingQueue checkPalindrome= new PalindromeCheckerUsingQueue();
                    checkPalindrome.ParenthesesChecker(s);
                    break;
                //Hashing Function to search a Number in a slot
                case 6:                    
                    HashingFunction hashingFunction = new HashingFunction(11);
                    hashingFunction.Numbers();
                    hashingFunction.Display();
                    Console.WriteLine("\n\nEnter any number : ");
                    int no = Convert.ToInt32(Console.ReadLine());
                    hashingFunction.Search(no);
                    hashingFunction.Display();
                    break;
                // Store Prime numbers in 2D Array
                case 8:
                    bool[,] arr = PrimeNumbers.PrimeNumbersInRange();
                    PrimeNumbers.Display(arr);
                    break;
                // Store Prime numbers in 2D Array which are Anagram numbers
                case 9:
                    PrimeNumbers.PrimeNumbersInRange();
                    bool[,] array = PrimeNumbers.AnagramPrimeNumbersInRange();
                    PrimeNumbers.Display(array);
                    break;
                // Store Prime numbers in Stack Linked List
                case 10:
                    PrimeNumbers.PrimeNumbersInStack();
                    break;
                // Store Prime numbers in Queue Using Linked List
                case 11:
                    PrimeNumbers.PrimeNumbersInQueue();
                    break;
            }
            Console.ReadLine();
        }
    }
}
