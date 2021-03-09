using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ValueTypes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;
            isDeclared = true;

            bool isDeclaredAndInitalized = false;

            isDeclaredAndInitalized = true;
        }
        [TestMethod]
        public void Characters()
        {
            char character = 'a';
            char symbol = '?';
            char number = '7';
            char space = ' ';
            char specialCharacter = '\n';
            //\n=newline
        }
        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;
            sbyte sByteExample = 127;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intmin = 2147483647;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;

            int a = 15;
            int b = -15;

            byte age = 25;

        }
        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.045231f;
            double doubleExample = 1.789053278907036d;
            decimal decimalExample = 1.257890728904578978978978978789m;

            Console.WriteLine(1.257890728904578978978978978789f);
            Console.WriteLine(1.257890728904578978978978978789d);
            Console.WriteLine(1.257890728904578978978978978789m);

        }
        enum PastryType { Cakes, CupCake, Eclaire, Petitfour, Croissant }
        [TestMethod]
        public void Enums()
        {
            PastryType mPastry = PastryType.Petitfour;
            PastryType anotherOne = PastryType.Cakes;
        }

        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;

            DateTime birthday = new DateTime(1800, 6, 20);

        }
    }
}
