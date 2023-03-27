using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BasicLessons.d94Collections.Assignment
{
    class Stack<T>
    {
        int MAX, top;
        T[] stack;
        public Stack()
        {
            top = -1;
            MAX = 10;
            stack = new T[MAX];
        }

        public Stack(int Size)
        {
            top = -1;
            MAX = Size;
            stack = new T[MAX];
        }
        public void Push(T data)
        {
            if (top == MAX)
            {
                stack=IncreaseSizeOfStack(stack);
            }
            stack[++top] = data;
        }
        public void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
        public void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
                Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
        }
        public T Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return default(T);
            }
            else
            {
                T value = stack[top--];
                MAX--;
                return value;
            }
        }
        private T[] IncreaseSizeOfStack(T[] oldstack)
        {
            int oldLength = oldstack.Length;
            T[] newStack = new T[oldLength + 10];
            for(int i=0;i<oldLength;i++)
            {
                newStack[i] = oldstack[i];
            }
            return newStack;
        }

    }
    class TestStackProgram
    {

        public static void TestA()
        {

            Console.WriteLine("Enter the Size of Stack:");

            int StackSize = int.Parse(Console.ReadLine());

            Stack<int> myStack = new Stack<int>(StackSize);
            Console.WriteLine("Enter the Stack Value:");

            for (int i = 0; i < StackSize; i++)
            {
                myStack.Push(int.Parse(Console.ReadLine()));
            }
            myStack.PrintStack();

            myStack.Peek();
            Console.WriteLine("POP the Stack:" + myStack.Pop());
            Console.Write("After POP the Stack:");
            myStack.PrintStack();
            Console.WriteLine("Enter the Stack Value:");
            myStack.Push(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter the Stack Value:");
            myStack.Push(int.Parse(Console.ReadLine()));
            myStack.PrintStack();

        }
        public static void TestB()
        {

            Console.WriteLine("Enter the Size of Stack:");
            int StackSize = int.Parse(Console.ReadLine());
            Stack<String > myStack = new Stack<String>(StackSize);
            Console.WriteLine("Enter the Stack Value:");

            for (int i = 0; i < StackSize; i++)
            {
                myStack.Push(Console.ReadLine());
            }

            //myStack.PrintStack();
            myStack.Peek();

            Console.WriteLine("POP the Stack:" + myStack.Pop());
            Console.WriteLine("After POP the Stack:");

            myStack.PrintStack();
        }
    }
}

