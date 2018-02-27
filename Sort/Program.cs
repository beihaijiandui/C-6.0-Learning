using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSort();
        }

        public static void TestSort()
        {
            //test list
            List<Square> listOfSquares = new List<Square>() { new Square(1,3),new Square(4,3),new Square(2,1),new Square(6,1)};
            Console.WriteLine("List<Square>");
            Console.WriteLine("Original list:");
            foreach (Square square in listOfSquares)
            {
                Console.WriteLine(square.ToString());
            }

            Console.WriteLine();
            IComparer<Square> heightCompare = new CompareHeight();
            listOfSquares.Sort(heightCompare);
            Console.WriteLine("Sorted list using Icomparer<Square>=heightCompare");
            foreach (Square square in listOfSquares)
            {
                Console.WriteLine(square.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Sorted list using Icomparable<Square>");
            listOfSquares.Sort();
            foreach (Square square in listOfSquares)
            {
                Console.WriteLine(square.ToString());
            }


            //test sortedlist
            var sortedListOfSquares = new SortedList<int, Square>() {
                { 0,new Square(1,3)}, { 2,new Square(3,3)}, { 1,new Square(2,1)}, { 3,new Square(6,1)}
            };
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("SortedList<Square>");
            foreach (KeyValuePair<int,Square> kvp in sortedListOfSquares)
            {
                Console.WriteLine($"{kvp.Key }:{ kvp.Value}");
            }
        }
    }

}
