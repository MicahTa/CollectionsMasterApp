using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void NumberPrinter(int[] numbers) {
            foreach (int i in numbers) {
                Console.Write($"{i}\t");
            }
            Console.Write("\n");
        }

        static int CountMultipleOfThree(int[] numbers) {
            int count = 0;
            foreach (int i in numbers) {
                if (i % 3 == 0) {count++;}
            }
            return count;
        }
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇
            Random rnd = new Random();


            #region Arrays
            // Create random array
            int[] numbers = new int[50];

            for (int i = 0; i < 50; i++) {
                numbers[i] = rnd.Next(0, 50);
            }


            // Print the first and last number of the array
            Console.WriteLine($"First number\n{numbers[0]}");
            Console.WriteLine($"Last number\n{numbers[49]}\n");          

            // Print all numbers
            Console.WriteLine("All Numbers");
            NumberPrinter(numbers);
            Console.Write("\n");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(numbers);
            NumberPrinter(numbers);
            Console.Write("\n");



            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            int multiplesOfThree = CountMultipleOfThree(numbers);
            Console.WriteLine($"Multiple of three = {multiplesOfThree}: ");
            Console.Write("\n");




            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbers);
            NumberPrinter(numbers);
            Console.Write("\n");
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            

            //TODO: Print the capacity of the list to the console
            

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            

            //TODO: Print the new capacity
            

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            

            //TODO: Clear the list
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            
        }

        private static void OddKiller(List<int> numberList)
        {
            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

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
