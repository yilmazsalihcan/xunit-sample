using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XunitSample.Services;

namespace Xunit.Services.Tests
{
    public class MathematicsTestClassFixture : IClassFixture<Mathematics>
    {
        Mathematics _mathematics;
        public MathematicsTestClassFixture(Mathematics mathematics)
        {
            _mathematics = mathematics;
        }

        [Theory,InlineData(3,5,15)]
        public void MultiplyTest(int number1,int number2,int expected)
        {
            //Arrange


            //Act
            int actual = _mathematics.Multiply(number1, number2);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
