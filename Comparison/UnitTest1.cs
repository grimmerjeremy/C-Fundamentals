using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Comparison
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComparisonOpperators()
        {
            //start with our variables
            int age = 25;
            string userName = "Terry";

            //check to see if something is = to something else
            bool equals = age == 41;
            Console.WriteLine(equals);

            bool userIsTerry = userName == "Terry";
            Console.WriteLine(userIsTerry);
            Console.WriteLine("userName is 41:" + equals);

            //using the '!'(bang) operator
            bool notequal = age != 122;
            Console.WriteLine($"User is not 122: {notequal}");

            //!= is not
            bool userIsNotJustin = userName != "Justin";
            Console.WriteLine(userIsNotJustin);

            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            //compare list
            bool listAreEqual = firstList == secondList;
            Console.WriteLine($"The list are equal?: {listAreEqual}");

            //greater than
            bool greaterThan = age > 12;
            Console.WriteLine(greaterThan);

            //greater than or equal to
            bool greaterThanOrEqual = age >= 24;
            Console.WriteLine(greaterThanOrEqual);

            //Less than
            bool lessThan = age < 66;
            Console.WriteLine(lessThan);

            //Less than or equal to
            bool lessThanOrEqual = age <= 12;
            Console.WriteLine(lessThanOrEqual);

            //we have the or '||'
            bool orValue = equals || lessThan;

            bool trueValue = true;
            bool falseValue = false;

            bool tOrT = trueValue || trueValue;
            bool tOrF = trueValue || falseValue;
            bool fOrT = falseValue || trueValue;
            bool fOrF = falseValue || falseValue;

            //() -> methodCall
            Console.WriteLine($"True or True {tOrT}");
            Console.WriteLine($"True or False {tOrF}");
            Console.WriteLine($"False or True {fOrT}");
            Console.WriteLine($"False or False {fOrF}");

            //and '&&'
            bool andValue = greaterThan && orValue;

            bool tAndT = trueValue && trueValue;
            bool tAndF = trueValue && falseValue;
            bool fAndT = falseValue && trueValue;
            bool fAndF = falseValue && falseValue;

            Console.WriteLine($"True or True {tAndT}");
            Console.WriteLine($"True or False {tAndF}");
            Console.WriteLine($"False or True {fAndT}");
            Console.WriteLine($"False or False {fAndF}");


        }
    }
}
