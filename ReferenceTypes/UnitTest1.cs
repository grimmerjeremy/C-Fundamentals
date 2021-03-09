using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ReferenceTypes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Strings()
        {
            string name;

            string declared;

            declared = "this is initalized.";

            string declareAndInitalize = "This is both declaring and initalizing";

            string firstName = "Jerry";
            string lastName = "grimmer";

            string concatenatedFullName = firstName + " " + lastName;

            string interpolationFullName = $"{firstName} {lastName}";

            string compositFullName = string.Format("{0} {1}", firstName, lastName);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(concatenatedFullName);
            Console.WriteLine(interpolationFullName);
            Console.WriteLine(compositFullName);

        }
        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello World";

            string[] stringArray = { "Hello", "World!", "Why", "is it", "always", stringExample };

            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem);

            //0-index (In the array line above the first word, hello, is set to 0.
            //So, when we ask for the third item from array position 2, we get Why.
            //The third item is in position 2.

            stringArray[0] = "Hey There";
            Console.WriteLine(stringArray[0]);

            //ctrl. look for "using"
            // "name of the list----------container for the list"
            List<string> listOfStrings = new List<String>();
            List<int> listOfInts = new List<int>();

            listOfStrings.Add("First string for our list.");
            listOfInts.Add(12356);

            Console.WriteLine(listOfInts[0]);

            Queue<string> firstInFirstOut = new Queue<string>();

            firstInFirstOut.Enqueue("I'm First");
            firstInFirstOut.Enqueue("I'm Next");

            string firstItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstItem);


            //Dictionary uses a value and definition in each individual line. They are then tied together.
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

            keyAndValue.Add(7, "Agent");
            keyAndValue.Add(3, "Bunny");

            string valueSeven = keyAndValue[7];
            string valueBunny = keyAndValue[3];
            Console.WriteLine(valueBunny);

            SortedList<int, string> sortedKeyAndValue = new SortedList, < int, string> ();
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> lastInFirstOut = new Stack<string>();

        }
        [TestMethod]
        public void Classes()
        {
            Random rng = new Random();

            int randomNumber = rng.Next();

            Console.WriteLine(randomNumber);

        }

    }
}
