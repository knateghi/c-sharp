using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Stack<int> numbers = new Stack<int>();

                Console.Write("How many digits does your number contain? ");
                int count = Convert.ToInt32(Console.ReadLine());
                Console.Write("Starting from left, enter as follows: ");
                for (int i = 1; i <= count; i++)
                {
                    Console.Write($"Digit # {i} is: ");
                    numbers.Push(Convert.ToInt32(Console.ReadLine()));
                }
                Console.WriteLine("\n========================< Stack >=======================");
                Console.WriteLine("Stack List");
                foreach (int i in numbers)
                {

                    Console.Write(" " + i);
                }
                Console.WriteLine("\n========================<  End  >=======================");
                Console.WriteLine();
                Console.WriteLine();

                Queue<int> que = new Queue<int>();

                reverseStack(numbers, que);
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter numbers only.");
                Console.WriteLine("You have to start over.");
            }


        }
        public static void reverseStack(Stack<int> numbers, Queue<int> que)
        {
            Console.WriteLine("\n====================< Reversed Stack >==================");
            Console.WriteLine("Reversed Stack list: ");

            while (true)
            {
                que.Enqueue(numbers.Pop());
                if (numbers.Count == 0)
                {
                    break;
                }
            }

            while (true)
            {
                numbers.Push(que.Dequeue());

                if (que.Count == 0)
                {
                    break;
                }
            }
            // int[] arr = que.ToArray();
            // Array.Reverse(arr);
            foreach (int i in numbers)
            {
                Console.Write(" " + i);
            }

            Console.WriteLine("\n========================<  End  >=======================");
            Console.WriteLine();
            Console.ReadKey();


        }
    }
}