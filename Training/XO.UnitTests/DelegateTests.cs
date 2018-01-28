using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO.UnitTests
{
    [TestFixture]
    public class DelegateTests
    {
        public delegate void Del(string message);

        public void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        public void MethodWithCallback(int param1, int param2, Del callback)
        {
            callback("The number is: " + (param1 + param2).ToString());
        }

        public delegate int Sum(int a, int b);

        public int SumMethod(int a, int b)
        {
            return a + b;
        }

        [Test]
        public void MainTest()
        {
            // Instantiate the delegate.
            Del handler = DelegateMethod;

            // Call the delegate.
            handler("Hello World");

            MethodWithCallback(1, 2, handler);
        }

        [Test]
        public void SumTest()
        {
            Sum handler = SumMethod;

            var result = handler(1, 2);

            Console.WriteLine(result);
        }
    }
}
