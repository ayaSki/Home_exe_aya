using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class LinkedList
    {
        private Node Node {  get; set; }
        private Node Max {  get; set; }
        private Node Min { get; set; }
        private Node LastNode { get; set; }


        public LinkedList(int num)
        {
            this.Node = new Node(num);  
            LastNode = this.Node;
            Max = this.Node;
            Min = this.Node;
        }

        public void Append(int num)
        {
            Node newNode = new Node(num);
            LastNode.Next = newNode;
            LastNode = LastNode.Next;
            if(newNode.Value > Max.Value)
            {
                Max = newNode;
            }
            if(newNode.Value < Min.Value)
            {
                Min = newNode;
            }
        }

        public void Prepend(int num)
        {
            Node newNode = new Node(num);
            newNode.Next = this.Node;
            this.Node = newNode;
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
                list = list.Append(temp.Value);
                temp = temp.Next;
            }
            return list;
        }


        public bool IsCircular()
        {
            Node temp = this.Node;
            while(temp.Next != null && temp.Next != this.Node)
            {
                temp = temp.Next;
            }
            return temp.Next == this.Node;
        }


        private void Swap(Node first, Node second, Node beforeFirst)
        {
            beforeFirst.Next = second;
            first.Next = second.Next;
            second.Next = first;
        }


        public void Sort()
        {
            bool swapped;
            Node current;
            Node beforeCurrent;
            Node beforeCurrentSign;
            if (this.Node == null)
                return;

            do
            {
                swapped = false;
                current = this.Node.Next;
                beforeCurrent = this.Node;
                beforeCurrentSign = this.Node;

                if (beforeCurrent.Value > current.Value)
                {
                    beforeCurrent.Next = current.Next;
                    current.Next = beforeCurrent;
                    current = this.Node.Next;
                    beforeCurrent = this.Node;
                    beforeCurrentSign = this.Node;
                }

                while (current.Next != null)
                {
                    if (current.Value > current.Next.Value)
                    {
                        Swap(current, current.Next, beforeCurrent);
                        swapped = true;
                        beforeCurrent = beforeCurrentSign;
                        current = beforeCurrentSign.Next;
                    }
                    current = current.Next;
                    beforeCurrent = beforeCurrent.Next;
                    beforeCurrentSign = beforeCurrentSign.Next;
                }
            } while (swapped);
        }


        public Node GetMaxNode()
        {
            return Max;
        }

        public Node GetMinNode()
        {
            return Min;
        }

        public void print()
        {
            Node temp = this.Node;
            while(temp != null)
            {
                Console.WriteLine(temp.Value);
                temp = temp.Next;
            }
        }
    }
}
