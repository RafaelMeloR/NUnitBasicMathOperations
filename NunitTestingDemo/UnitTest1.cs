using NUnit.Framework;
using NunitTestingDemo;

namespace NUnitTest
{
    public class Tests
    {
       

        [Test]
        public void TestAdditionValues()
        {
            //1-Arrange
            Program program = new Program();

            //2- Act
            double result= program.AddTwoValues(2, 9.2);

            //Assert
            Assert.That(result,Is.EqualTo(11.2));
           // Assert.Equals(result, 11.2);
        }

        [Test]
        public void TestMinusValues()
        {
            //1-Arrange
            Program program = new Program();

            //2- Act
            double result = program.MinusTwoValues(10, 1);

            //Assert
            Assert.That(result, Is.EqualTo(9));
        }

        [Test]
        public void TestMultiplyValues()
        {
            //1-Arrange
            Program program = new Program();

            //2- Act
            double result = program.MultTwoValues(10, 2);

            //Assert
            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void TestDividedValues()
        {
            //1-Arrange
            Program program = new Program();

            //2- Act
            double result = program.DivisionTwoValues(10, 2);

            //Assert
            Assert.That(result, Is.EqualTo(5));
        }
    }
}