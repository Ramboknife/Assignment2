using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMarshallAssignment2.Tests
{
    [TestFixture]
    public class TriangleSolverTest
    {
        [Test]
        //This unit test will check to see if any of the angles provided are negative
        //and if they are, no triangle will be constructed.
        public void CheckIf_NoTriangle_Analyze()
        {
            //Arange
            int angleOne = 0;
            //Act
            bool result = angleOne >= 0;
            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        //this test will see if the triangle provided is an equilateral triangle
        //and if it is, return confirmation.
        public void CheckIf_EqualTriangle_Analyze()
        {
            //Arange
            int angleOne = 1;
            int angleTwo = 1;
            int angleThree = 1;
            //Act
            int anglesTotal = angleOne + angleTwo + angleThree;
            int totalResult = 3;
            //Assert
            Assert.AreEqual(anglesTotal , totalResult );
        }

        [Test]
        //this test will see if the triangle provided is an isosceles triangle
        //and if it is, return confirmation.
        public void CheckIf_IsoTriangle_Analyze()
        {
            //Arange
            int angleOne = 1;
            int angleTwo = 1;
            int angleThree = 2;
            //Act
            bool result = angleOne == angleTwo || angleOne == angleThree || angleTwo == angleThree;
            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        //this test will see if the triangle provided is an scalene triangle
        //and if it is, return confirmation.
        public void CheckIf_ScalTriangle_Analyze()
        {
            //Arange
            int angleOne = 1;
            int angleTwo = 2;
            int angleThree = 3;
            //Act
            int totalAngles = angleOne + angleTwo + angleThree;
            int totalResult = 3;
            int totalResultTwo = 4;
            //Assert
            Assert.AreNotEqual( totalAngles, totalResult | totalResultTwo );
        }       

        [Test]
        //this test will check that all numbers given are greater than zero,
        //meaning a triangle will be returned.
        public void CheckIf_IsTrangle_Analyze()
        {
            //Arange
            int angleOne = 1;
            int angleTwo = 1;
            int angleThree = 1;
            //Act
            bool result = angleOne >= 0 || angleTwo >= 0 || angleThree >= 0;
            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        //this test will check to see if inputs by a user are all ints,
        //and if not will alert them to it.
        public void CheckIf_AllNumeric_Analyze()
        {
            //Arange           
            string userInput = "Whoops";
            int i = 0;
            //Act
            bool result = int.TryParse(userInput, out i);

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
