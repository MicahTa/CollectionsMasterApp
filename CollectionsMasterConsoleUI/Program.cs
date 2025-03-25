using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.Arm;


namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            // Create random array
            int[] numbers = new int[50];
            Populater(numbers);


            // Print the first and last number of the array
            Console.WriteLine($"First number\n{numbers[0]}");
            Console.WriteLine($"Last number\n{numbers[49]}\n");          

            // Print all numbers
            Console.WriteLine("All Numbers");
            NumberPrinter(numbers);
            Console.Write("\n");

            //Reverse the contents of the array and then print the array out to the console.
            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(numbers);
            NumberPrinter(numbers);
            Console.Write("\n");


            // Remove all multiples of three
            Console.WriteLine($"NonMultiples of three = ");
            ThreeKiller(ref numbers);
            Console.Write("\n");

            // Sort
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbers);
            NumberPrinter(numbers);
            Console.Write("\n");
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion


            #region Lists
            Console.WriteLine("************Start Lists**************");

            //Create list
            var list = new List<int>();

            Console.WriteLine($"List Capacity: {list.Capacity}");

            // Add Random values
            Populater(list);         
    
            Console.WriteLine($"List Capacity After Population: {list.Capacity}");
            

            Console.WriteLine("---------------------");

            // get number to search for
            bool correctInput = false;
            int searchParsed = 0;

            do {
                Console.WriteLine("What number will you search for in the number list?");
                string search = Console.ReadLine();
                if (int.TryParse(search, out int parsedInt)) {
                    searchParsed = int.Parse(search);
                    correctInput = true;
                } else {
                    Console.WriteLine("Invalid format");
                }
            } while (!correctInput);

            NumberChecker(list, searchParsed);

            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(list);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(ref list);
            NumberPrinter(list);
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            list.Sort();
            NumberPrinter(list);
            
            Console.WriteLine("------------------");

            //Convert and clear
            int[] myArray = list.ToArray();
            list.Clear();

            

            #endregion
        }

        private static void ThreeKiller(ref int[] numbers)
        {
            int[] newArray = numbers.Where(x => x % 3 != 0).ToArray();
            numbers = newArray;
            NumberPrinter(numbers);
        }

        private static void OddKiller(ref List<int> numberList)
        {
            numberList = numberList.Where(n => n % 2 == 0).ToList();
            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber)) {
                Console.WriteLine($"Yes, {searchNumber} is in the list");
            } else {
                Console.WriteLine($"No, {searchNumber} is not in the list");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++) {
                numberList.Add(rng.Next(0, 50));
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

            for (int i = 0; i < 50; i++) {
                numbers[i] = rng.Next(0, 50);
            }
        }        

        private static void ReverseArray(int[] array)
        {
            
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
