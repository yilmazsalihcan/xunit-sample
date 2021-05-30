using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XunitSample.Services;

namespace Xunit.Services.Tests
{
    public class MathematicsTestMocking
    {
        [Fact]
        public void SumTest()
        {
            //Arrange
            var mathematics = new Mock<IMathematics>();
            mathematics.Setup(m => m.Sum(1, 2))
                .Returns(3);
            //Act
            int actual = mathematics.Object.Sum(1, 2);

            //Assert
            Assert.Equal(3, actual);
        }


        /// <summary>
        /// Verify : Bir methodun kaç kez çalıştığını test edebilmek için kullanılır.
        /// </summary>
        [Fact]
        public void SumTestVerify()
        {
            //Arrange
            var mathematics = new Mock<IMathematics>();
            mathematics.Setup(m => m.Sum(1, 2))
            .Returns(3);

            //Act
            int actual = mathematics.Object.Sum(1, 2);

            //Assert
            Assert.Equal(3, actual);

            mathematics.Verify(x => x.Sum(1, 2), Times.AtLeast(2));

        }

        [Fact]
        public void DivideTest()
        {

            Mathematics mathematics = new Mathematics();
            var mathematicsMock = new Mock<IMathematics>();
            mathematicsMock.Setup(m => m.Divide(1, 0))
                           .Throws<DivideByZeroException>();

            var exception = Assert.Throws<DivideByZeroException>(() => mathematics.Divide(1, 0));
        }

        [Fact]
        public void SumTestItsAny()
        {
            int result = 0;
            var mathematics = new Mock<IMathematics>();
            mathematics.Setup(m=>m.Sum(It.IsAny<int>(),It.IsAny<int>()))
                        .Callback<int,int>((number1,number2)=>result = number1 + number2);

            mathematics.Object.Sum(1, 2);
            Assert.Equal(3, result);

            mathematics.Object.Sum(5, 5);
            Assert.Equal(10, result);



        }

    }

}
