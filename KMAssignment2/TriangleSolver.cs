using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMAssignment2
{
    public class TriangleAnalyzer
    {
        private int numberOne = 1;
        private int numberTwo = 1;
        private int numberThree = 1;

        public TriangleAnalyzer()
        {

        }

        public void SetNumberOne(int numberOne)
        {
            this.numberOne = numberOne;
        }

        public void SetNumberTwo(int numberTwo)
        {
            this.numberTwo = numberTwo;
        }

        public void SetNumberThree(int numberThree)
        {
            this.numberThree = numberThree;
        }

        public string Analyize()
        {

            if (numberOne <= 0 || numberTwo <= 0 || numberThree <= 0)
            {
                Console.WriteLine($"Your have entered a number 0 or less, and therefore no triangle is formed!");
            }

            else if (numberOne == numberTwo && numberTwo == numberThree)
            {
                Console.WriteLine($"Your have made an Equilateral Triangle!");

            }

            else if (numberOne == numberTwo || numberOne == numberThree || numberTwo == numberThree)
            {
                Console.WriteLine($"Your have made an Isosceles Triangle!");

            }

            else if (numberOne != numberTwo || numberTwo != numberThree || numberOne != numberThree)
            {
                Console.WriteLine($"Your have made a Scalene Triangle!");
            }

            string tryAgain = "Please try again!";
            return tryAgain;
        }
    }
}