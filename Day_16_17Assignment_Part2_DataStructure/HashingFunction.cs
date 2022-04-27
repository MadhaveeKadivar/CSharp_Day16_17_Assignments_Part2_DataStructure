using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_16_17Assignment_Part2_DataStructure
{
    internal class HashingFunction
    {
        public int size;
        public LinkedList<int>[] list;
        public HashingFunction(int size)
        {
            this.size = size;
            this.list = new LinkedList<int>[size];
        }
        public void Numbers()
        {
            Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                int num = random.Next(0, 50);
                Add(num);
            }
        }
        public void Add(int no)
        {
            var linkedList = GetArrayPositionAndLinkedList(no);
            if (linkedList != null)
            {
                if (linkedList.Contains(no) == true)
                {
                    return;
                }
            }
            linkedList.AddLast(no);
        }
        public void Search(int no)
        {
            var linkedList = GetArrayPositionAndLinkedList(no);
            foreach (int n in linkedList)
            {
                if (no.Equals(n))
                {
                    Console.WriteLine($"\n{no} is found");
                    Remove(n);
                    return;
                }
            }   
            Console.WriteLine($"\n{no} is not found");
            Add(no);
            Console.WriteLine($"\n{no} added successfully in Hash Table");                   
        }
        public LinkedList<int> GetArrayPositionAndLinkedList(int no)
        {
            int position = GetArrayPostion(no);
            LinkedList<int> linkedList = GetLinkedList(position);
            return linkedList;
        }
        public int GetArrayPostion(int no)
        {
            int hash = no.GetHashCode(); // storing hashcode of word
            int position = hash % size; //Resizing the hash code according the size of hashtable
            return Math.Abs(position); // Take the only positive integer
        }
        //creating a linkedlist at particular position to maintain multiple key value pair at same position in hash table
        public LinkedList<int> GetLinkedList(int position)
        {
            var linkedList = list[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<int>();
                list[position] = linkedList; // If there is no linkedlist created at position then create new linked list
            }
            return linkedList;
        }
        public void Remove(int no)
        {
            var linkedList = GetArrayPositionAndLinkedList(no);
            bool keyFound = false;
            int foundItem = 0;
            foreach (int n in linkedList)
            {
                if (n.Equals(no))
                {
                    keyFound = true;
                    foundItem = no;
                }
            }
            if (keyFound)
            {
                linkedList.Remove(foundItem);
                Console.WriteLine($"\n{no} removed successfully from Hash Table");
            }
        }
        public void Display()
        {
            int a = 0;
            Console.WriteLine($"\n\nNumbers present at Particular Position of Hash Table are : ");
            foreach (var numList in list)
            {
                Console.Write($"\n\nPosition {a} :  ");
                if (numList!=null)
                {
                    foreach (int i in numList)
                    {
                       Console.Write(i+"  ");
                    }
                }
                a++;
            }
        }
    }
}
