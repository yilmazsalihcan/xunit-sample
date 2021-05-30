using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XunitSample.Services;

namespace Xunit.Services.Tests
{
    public class SampleTest
    {
        Mock<ISample> _mockSample;
        SampleService _sampleService;
        public SampleTest()
        {
            _mockSample = new Mock<ISample>();
            _sampleService = new SampleService(_mockSample.Object);
        }

        [Fact]
        public void Sample_Test()
        {
            _mockSample.Setup(m => m.Check()).Returns(5);
            _sampleService.Check();
            _mockSample.Verify(s => s.Handler(), Times.Once());
        }


    }
}
