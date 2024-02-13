using NUnit.Framework.Legacy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Nunitdemonstration.Class1;

namespace TestClassFinal
{
    public class Class1
    {
        [TestFixture]

        public class TraingleTest1
        {
            [Test]

            //Sushmitha Ranjith's UNIT TESTING

            public void ValidTriangle()
            {
                //Arrange
                int firstAngle = 60;
                int secondAngle = 60;
                int thirdAngle = 60;
                String expected = "The triangle is valid.";

                //Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
                ClassicAssert.AreEqual(expected, actual);

            }
        }
    }
}