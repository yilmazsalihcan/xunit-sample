using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XunitSample.Services;

namespace Xunit.Services.Tests
{
    public class MathematicsTestRefactor
    {
        Mathematics _mathematics;
        public MathematicsTestRefactor()
        {
            _mathematics = new();
        }

        [Theory]
        [ClassData(typeof(TypeSafeData))]
        public void SumTest(int number1,int number2,int expected)
        {
            //Act
            int actual = _mathematics.Sum(number1,number2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubtractTest()
        {
            //Arrange
            int number1 = 10;
            int number2 = 20;
            int expected = -10;
            //Act
            int actual = _mathematics.Substract(number1, number2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory,InlineData(3,5)]
        public void MultiplyTest(int number1,int number2)
        {
            //Act
            int actual = _mathematics.Multiply(number1, number2);
            //Assert
            Assert.Equal(15, actual);
        }

        [Theory,InlineData(30,5,6)]
        public void DivideTest(int number1,int number2,int expected)
        {
            //Act
            int actual = _mathematics.Divide(number1, number2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }

    public class TypeSafeData : TheoryData<int, int, int>
    {
        public TypeSafeData()
        {
            Add(3, 5, 8);
            Add(11, 5, 16);
            Add(23, 2, 25);
            Add(33, 44, 87);
        }
    }
}
