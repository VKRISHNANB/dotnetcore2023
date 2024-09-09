using System;
namespace StackDemo
{
    class StackDemoA
    {
        public static void TestLinkListStack()
        {
            LinkListStack stack = new LinkListStack();
            int con = 0;
            do
            {
                Console.WriteLine("enter the Choice 1. Push 2. Pop 3. Display");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("enter the elemnet ");
                        int val = int.Parse(Console.ReadLine());
                        stack.Push(val);
                        break;
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        stack.Display();
                        break;
                    default:
                        Console.WriteLine("Enter the Corrct choice");
                        Console.WriteLine("to continue enter 1. Yes 2. No");
                        con = int.Parse(Console.ReadLine());
                        break;
                }
                Console.WriteLine("to continue enter 1. Yes 2. No");
                con = int.Parse(Console.ReadLine());
            } while (con == 1);

            Console.ReadLine();
        }

    }
}
namespace StackDemo
{
    internal class Node
    {
        internal int data;
        internal Node next;

        // Constructor to create a new node . Next is by default initialized as null  
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
    internal class LinkListStack
    {
        Node top;
        public LinkListStack()
        {
            this.top = null;
        }
        internal void Push(int value)
        {
            Node newNode = new Node(value);
            if (top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;
            Console.WriteLine("{0} pushed to stack", value);
        }
        internal void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack Underflow. Deletion not possible");
                return;
            }

            Console.WriteLine("Item popped is {0}", top.data);
            top = top.next;
        }
        internal void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine("Item peek is {0}", top.data);
        }
        internal void Display()
        {
            Node temp = top;
            if (temp == null)
                Console.WriteLine("stack is underflow ");
            while (temp != null)
            {
                Console.WriteLine("{0} is on the  of Stack", temp.data);
                temp = temp.next;
            }
        }
    }
}

