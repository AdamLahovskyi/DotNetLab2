using ExtensionsLibrary;
using ExtentionsLibrary;
using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PT 1.\n");
            string txt = "hello, world";
            Console.WriteLine($"Before reverse: {txt}");
            Console.WriteLine("After reverse: ");
            Console.WriteLine($"{txt.ReverseString()}\n");

            Console.WriteLine("PT 2.\n");

            string txt2 = "programming";
            char targetChar = 'm';
            int count = txt2.CountOccurrences(targetChar);
            Console.WriteLine($"{targetChar}'s in text: {count}\n");

            Console.WriteLine("PT 3.\n");

            int[] intArray = { 22, 1, 23, 51, 123, 22 };
            Console.Write("Array elements: ");
            foreach (int i in intArray)
            {
                Console.Write($"{i} ");
            }
            int target = 22;
            Console.WriteLine("\nOccurrences of 22 in array: " + intArray.CountValueOccurrences(target) + "\n");

            Console.WriteLine("PT 4.\n");

            string[] stringArray = { "hello", "world", "seesharp" };
            Console.Write("Array elements: ");
            foreach (string i in stringArray)
            {
                Console.Write($"{i} ");
            }
            string targetWord = "hello";
            Console.WriteLine("\nOccurrences of 'hello' in array: " + stringArray.CountValueOccurrences(targetWord) + "\n");

            Console.WriteLine("PT 5.\n");
            Console.Write("Array elements: ");
            foreach (int i in intArray)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\nUnique values only: ");
            int[] uniqueArray = intArray.ReturnUniqueArray();
            foreach (int i in uniqueArray)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\n\nPT 6.\n");
            var extendedDictionary = new ExtendedDictionary<string, string, string>();
            extendedDictionary.AddElements("hello", "One", "apple");
            extendedDictionary.AddElements("thursday", "Two", "peach");
            extendedDictionary.AddElements("bye", "Three", "banana");

            Console.WriteLine("Extended Dictionary:");
            Console.WriteLine(extendedDictionary);

            Console.WriteLine($"Does dictionary contain key 'hello'? {extendedDictionary.CheckIfDictContainsKey("hello")}");

            string keyToCheck = "bye"; 
            Console.WriteLine($"Value for key '{keyToCheck}': {extendedDictionary[keyToCheck]}");

            Console.WriteLine("\nIterating over the dictionary:");
            foreach (var item in extendedDictionary)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
