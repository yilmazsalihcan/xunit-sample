using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XunitSample.Services
{
    public class SampleService
    {
        ISample _sample;

        public SampleService(ISample sample)
        {
            _sample = sample;
        }

        public int Check()
        {
            _sample.Handler();
            return _sample.Check();
        }

        public void Handler() => _sample.Handler();
    }
}
