using System;
using System.Collections.Generic;

namespace TestYield
{
    class Program
    {
        static List<int> MyList = new List<int>();
        static List<string> MyWordList = new List<string>();

        static void FillValues()
        {
            MyList.Add(1);
            MyList.Add(2);
            MyList.Add(3);
            MyList.Add(4);
            MyList.Add(5);
        }

        static void FillWordValues()
        {
            MyWordList.Add("dog");
            MyWordList.Add("cat");
            MyWordList.Add("monkey");
            MyWordList.Add("giraffe");
            MyWordList.Add("seagull");
        }
        static void Main(string[] args) // Caller
        {
            FillValues();
            FillWordValues();
            // Fills the list with 5 values
            foreach (var output in FilterWordsWithYield()) // Browses through the list
            {
                Console.WriteLine(output);
            }
            Console.ReadLine();
        }

        static IEnumerable<int> FilterWithYield()

        {
            foreach (int i in MyList)
            {
                if (i > 3) yield return i;
            }
        }

        static IEnumerable<string> FilterWordsWithYield()

        {
            foreach (string word in MyWordList)
            {
                if (word.Contains("a")) yield return word;
            }
        }
    }
}
