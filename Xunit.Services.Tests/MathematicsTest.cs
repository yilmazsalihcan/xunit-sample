using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XunitSample.Services;

namespace Xunit.Services.Tests
{
    public class MathematicsTest
    {

        [Fact]
        public void SubstractTest()
        {
            //Arrange 
            int number1 = 10;
            int number2 = 20;
            int expected = -10;
            Mathematics mathematics = new Mathematics();
            //Act
            int actual = mathematics.Substract(number1, number2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3,5,8)]
        [InlineData(11,5,16)]
        [InlineData(23,2,25)]
        [InlineData(5,6,12)]
        public void SumTest(int number1,int number2,int expected)
        {

            //Arrange
            Mathematics mathematics = new Mathematics();

            //Act
            int actual = mathematics.Sum(number1, number2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(Datas.sumDatas),MemberType = typeof(Datas))]
        public void SumTestWithMemberData(int number1,int number2,int expected)
        {
            //Arrange
            Mathematics mathematics = new Mathematics();

            //Act
            int actual = mathematics.Sum(number1, number2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [ClassData(typeof(DatasOfClass))]
        public void SumTestWithClassData(int number1,int number2,int expected)
        {
            //Arrange
            Mathematics mathematics = new Mathematics();
            //Act
            int actual = mathematics.Sum(number1, number2);
            //Assert
            Assert.Equal(expected, actual);
        }

      

    }

    public class Datas
    {
        public static IEnumerable<object[]> sumDatas => new List<object[]>
        {
            new object[]{3,5,8},
            new object[]{11,5,16},
            new object[]{23,2,25},
            new object[]{33,44,87}
        };
    }

    public class DatasOfClass : IEnumerable<object[]>
    {

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 3, 5, 8 };
            yield return new object[] { 11, 5, 16 };
            yield return new object[] { 23, 2, 25 };
            yield return new object[] { 33, 44, 87 };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
