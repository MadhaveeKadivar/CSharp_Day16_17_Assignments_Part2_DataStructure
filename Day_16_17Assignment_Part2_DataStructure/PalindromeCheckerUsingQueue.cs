using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_16_17Assignment_Part2_DataStructure
{
    internal class PalindromeCheckerUsingQueue
    {
        private Node<char> top; // Creating variable to maintain Top of stack
        public void ParenthesesChecker(string expression)
        {
            char[] ch = expression.ToCharArray();
            foreach (char c in ch)
            {
               Enqueue(c);
            }
            string reverse = "";
            while(this.top != null)
            {
                char c = Dequeue();
                reverse = reverse+c;
            }
            if(expression.Equals(reverse))
            {
                Console.WriteLine($"\n{expression} is palindrome");
            }
            else
            {
                Console.WriteLine($"\n{expression} is not palindrome");
            }

        }
        public void Enqueue(char data) // Creating method to push element in Stack
        {
            Node<char> newNode = new Node<char>(data); // Creating a new node for one character
            if (this.top == null) // Checking that top is null
            {
                newNode.next = null; // If top is null then new node pointing to null
            }
            else
            {
                newNode.next = this.top; // If top is not null then new node is pointing where top is
            }
            this.top = newNode; // Making newnode as top of stack
        }
        public char Dequeue() // creating a method to Dequeue all Element in queue using Linked List
        {
            char dequeueChar;
            dequeueChar = this.top.data;
            this.top = this.top.next;
            return dequeueChar;
        }
    }
}
