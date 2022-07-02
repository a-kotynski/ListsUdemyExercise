using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.udemy.com/course/csharp-tutorial-for-beginners/learn/lecture/2979538#content
namespace ListsUdemyExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1,2,3,4}; // <> means generic
            numbers.Add(1);
            numbers.AddRange(new int[3] {5,6,7});

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            Console.WriteLine("Index of 1: "+numbers.IndexOf(1));
            Console.WriteLine("Index of 1: " + numbers.LastIndexOf(1));

            Console.WriteLine();
            Console.WriteLine("Count: " + numbers.Count);

            Console.WriteLine();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);
        }
    }
}