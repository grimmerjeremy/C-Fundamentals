using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Morning_Challenges
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void W1D3()
        {
            string mPoppins = "Supercalifragilisticexpialidocious";
            foreach (char letter in mPoppins)
            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                if (letter != 'i')
                {
                    Console.WriteLine("Not an i");
                }
            }
        }

        [TestMethod]
        public void Bonus()
        {
            string super = "Supercalifragilisticexpialidocious";
            int numOfLet = 0;
            for (int i = 0; i < super.Length; i++)
            {
                numOfLet++;    
            }
            Console.WriteLine(numOfLet);
        }

        [TestMethod]
        public void AnotherBonus()
        {
            string mPoppins = "Supercalifragilisticexpialidocious";
            foreach (char letter in mPoppins)
            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                if (letter == 'l')
                {
                    Console.WriteLine("L");
                }
                else
                {
                    Console.WriteLine("Not an i");
                }
            }
        }
    }
}
