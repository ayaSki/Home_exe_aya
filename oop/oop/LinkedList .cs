﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class LinkedList
    {
        private Node Node {  get; set; }


        public void Append(int num)
        {
            Node newNode = new Node(num);

            Node temp = this.Node;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }

        public void Prepend(int num)
        {
            Node newNode = new Node(num);
            newNode.Next = this.Node;
        }


        public int Pop()
        {
            Node temp = this.Node;
            while (temp.Next.Next != null)
            {
                temp = temp.Next;
            }
            int value = temp.Next.Value;
            temp.Next = null;
            return value;
        }

        public int Unqueue()
        {
            int value = 0;
            this.Node = Node.Next;
            return value;
        }


        public IEnumerable<int> ToList()
        {
            IEnumerable<int> list = new List<int>();
            Node temp = this.Node;
            while (temp != null)
            {
                list.Append(temp.Value);
            }
            return list;
        }


        public bool IsCircular()
        {
            Node temp = this.Node;
            while(temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp == this.Node;
        }


        public void Swap(Node first, Node second, Node beforeFirst)
        {
            beforeFirst.Next = second;
            first.Next = second.Next;
            second.Next = first;
        }


        public void Sort()
        {
            if(this.Node == null)
            {
                return;
            }
            Node temp = this.Node.Next;
            Node beforeCurrent = this.Node;


            if(temp.Value < beforeCurrent.Value)
            {
                beforeCurrent.Next = temp.Next;
                temp.Next = beforeCurrent;
            }

            while(temp.Next != null )
            {
                while(temp.Next != null)
                {
                    if(temp.Value > temp.Next.Value)
                    {
                        Swap(temp, temp.Next, beforeCurrent);
                    }
                    temp = temp.Next;
                    beforeCurrent = beforeCurrent.Next;
                }
            }
        }


        public Node GetMaxNode()
        {

        }
    }
}
