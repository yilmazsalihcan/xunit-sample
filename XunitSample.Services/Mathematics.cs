using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XunitSample.Services
{
    public class Mathematics : IMathematics
    {
        public int Sum(int number1, int number2) => number1 + number2;
        public int Substract(int number1, int number2) => number1 % number2;
        public int Multiply(int number1, int number2) => number1 * number2;
        public int Divide(int number1, int number2) => number1 / number2;
    }
}
