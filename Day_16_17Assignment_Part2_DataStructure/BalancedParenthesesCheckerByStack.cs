using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_16_17Assignment_Part2_DataStructure
{
    internal class BalancedParenthesesCheckerByStack
    {
        private Node<char> top; // Creating variable to maintain Top of stack
        public void ParenthesesChecker(string expression)
        {
            char[] ch = expression.ToCharArray();
            foreach (char c in ch)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    Push(c);
                }
                else if ((c == ')' && this.top.data == '(' )||(c == '}' && this.top.data == '{') || (c == ']' && this.top.data == '['))
                {
                    bool empty = isEmpty();
                    if(empty)
                    {
                        Console.WriteLine($"\n\"{expression}\" expression isn't balanced");
                    }
                    else
                    {
                        Pop();
                    }
                }
            }
            bool check = isEmpty();
            if (check)
            {
                Console.WriteLine($"\n\"{expression}\" expression is balanced");
            }
            else
            {
                Console.WriteLine($"\n\"{expression}\" expression is not balanced");
            }

        }       
        public void Push(char data) // Creating method to push element in Stack
        {
            Node<char> newNode = new Node<char>(data); // Creating a new node for data which is passed by user
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
        
        public void Pop() // Creating method to pop top of stack element
        {
            if (this.top == null) // Checking that top is null otherwise delete top element
            {
                return;
            }
            else
            {
                char deleteNode = this.top.data; // Storing top element
                this.top = top.next; // Delete top element
            }
        }
        public bool isEmpty() //Methhod to empty stack
        {
            if(this.top != null)  //Deleting top element untill stack is empty
            {
                return false;
            }
            return true;
        }
    }
}
