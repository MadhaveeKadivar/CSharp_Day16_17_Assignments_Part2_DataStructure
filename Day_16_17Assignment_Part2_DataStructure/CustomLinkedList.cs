using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_16_17Assignment_Part2_DataStructure
{
    internal class Node<T>
    {
        public T data; // data variable
        public Node<T> next; // declaring a next node
        public Node(T data) // Creating constructor having node data as parameter
        {
            this.data = data;

        }
    }
    internal class CustomLinkedList<T> where T : IComparable
    {
        public Node<T> head; // Creating head if linked list
        public void Append(T data) // creating generic method to Add element at first of linked list
        {
            Node<T> newNode = new Node<T>(data); // Creating a new node 
            if (this.head == null)
            {
                this.head=newNode; // If head pointing to null then hode is directly pointing to new node
                Console.WriteLine($"\n{newNode.data} word is appended in linked list");
                return;
            }
            else
            {
                Node<T> temp = this.head; // taking head as temp node
                while (temp.next != null) // Find a last node 
                {
                    temp = temp.next;// Go to next node till last nast node               
                }
                temp.next = newNode; // Add new Node at last
                Console.WriteLine($"\n{newNode.data} word is appended in linked list");
            }
        }
        public bool Search(T data)
        {
            Node<T> temp = this.head; // Creating a temp node having head reference
            if (temp == null) //Checking that list is empty or not
            {
                Console.WriteLine("\nLinked List is Empty");
                return false;
            }
            while (temp != null)
            {
                if (data.Equals(temp.data)) // Comparing linked list data to check that element is present or not
                {
                    Console.WriteLine($"\n{data} is present in linked list");
                    return true;
                }
                temp = temp.next; // Moving to next node
            }
            Console.WriteLine($"\n{data} is not present in linked list");
            return false;
        }
        public void Remove(T newElement)
        {
            Node<T> temp = this.head; // Creating a temp node having head reference
            Node<T> prev = null; // Declaring variable to store the prev node
            if (temp == null) //Checking that list is empty or not
            {
                Console.WriteLine("\nLinked List is Empty");
                return;
            }
            if (temp != null && newElement.Equals(temp.data)) // Checking if list has only one value which user wants to delete
            {
                Console.WriteLine($"\n{newElement} is deleted");
                head = temp.next; // Changing head reference
                return;
            }
            while (temp != null && !(newElement.Equals(temp.data))) // Continue moving till find a value which want to dlete
            {
                prev = temp; // Stoting value one by one in prev
                temp = temp.next; // Go to next node
            }
            prev.next = temp.next; // Deleting node which want to delete
            Console.WriteLine($"\n{newElement} is deleted");
        }
        public void DisplayElement() // creating generic method to display element at first of linked list
        {
            int count = 0;
            Node<T> temp = this.head; // taking head as temp node
            if (temp == null) // If head is null that means linked list is empty
            {
                Console.WriteLine("\n\nThe LinledList is Empty");
                return;
            }
            Console.WriteLine("\n\nElements of linked list in sequence are : \n");
            while (temp != null) // If head is not null then print one by one element of linked list
            {
                Console.WriteLine(temp.data+" ");
                count++;
                temp = temp.next; // Go to next node
            }
            Console.WriteLine($"\nSize of Linked List is : {count}");
        }
        public void AddWithAcsendingOrder(T data) // Creating a method to add element by ascending order
        {
            Node<T> newNode = new Node<T>(data); //Creating a new node with value by user
            //If Head is null make newnode as head otherwise add the element 
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                //If newnode is less than the head data then make new node ad head which is pointing to old head
                if (newNode.data.CompareTo(this.head.data) < 0)
                {
                    newNode.next=this.head;
                    this.head=newNode;
                }
                else
                {
                    Node<T> temp = this.head; // Creating a temp varible and store head it in
                    while (temp.next!=null && temp.next.data.CompareTo(data) < 0) //If new data is greater than all then move temp at last
                    {
                        temp=temp.next;
                    }
                    if (temp.next!=null) // If temp is pointing to any node then make add new node after temp
                    {
                        newNode.next = temp.next;
                        temp.next=newNode;
                    }
                    else // If temp is pointing to null then make add new node at last
                    {
                        temp.next = newNode;
                        newNode.next=null;
                    }
                }
            }
            Console.WriteLine($"\n{data} is Added in Linked List");
        }
        public void DeleteAtFirst() // creating generic method to delete element at first of linked list
        {
            if (this.head == null) //Checking that list is empty or not
            {
                Console.WriteLine("\nLinked List is already Empty");
                return;
            }
            Node<T> temp = this.head; // Creating a temp node having head reference
            Console.WriteLine($"\nNow deleting first element {temp.data} ....");
            this.head = this.head.next;  // Deleting a first node  
        }
    }
}
