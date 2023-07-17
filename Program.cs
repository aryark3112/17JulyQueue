using System;
using System.Collections;


namespace _17July
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Collections Continue

            //ArrayList list = new ArrayList();
            //Hashtable ht = new Hashtable();
            //SortedList sortedList = new SortedList();
            //Stack stack =  new Stack();
            //Queue queue = new Queue();

            //Stack example
            Stack stack = new Stack();
            stack.Push("Aman");
            stack.Push("Vijay");
            stack.Push("Zoya");
            stack.Push("Raj");
            stack.Push("Kiran");
            Console.WriteLine("Number of Items in stack are: \t"+stack.Count);
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After removing" + stack.Pop());
            Console.WriteLine("After removing "+ stack.Pop());
            Console.WriteLine("Number of Items in stack are: \t"+stack.Count);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Peek Example: \t"+stack.Peek());
            Console.WriteLine("After Peek");
            Console.WriteLine("Number of Items in stack are: \t"+stack.Count);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            stack.Clear();
            Console.WriteLine("After Clear Number of Items are: \t"+stack.Count);

            Console.ReadKey();
        }
        
    }
}
