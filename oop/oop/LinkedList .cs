using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class LinkedList
    {
        private Node Node {  get; set; }


        public LinkedList(int num)
        {
            this.Node = new Node(num);  
        }

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


        public void Swap(Node first, Node second, Node beforeFirst)
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
            Node temp = this.Node;
            Node max = this.Node;
            while(temp != null)
            {
                if(temp.Value > max.Value)
                {
                    max = temp;
                }
                temp = temp.Next;
            }
            return max;
        }

        public Node GetMinNode()
        {
            Node temp = this.Node;
            Node min = this.Node;
            while (temp != null)
            {
                if (temp.Value < min.Value)
                {
                    min = temp;
                }
                temp = temp.Next;
            }
            return min;
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
