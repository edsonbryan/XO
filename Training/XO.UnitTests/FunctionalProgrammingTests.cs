using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XO.UnitTests
{
    [TestFixture]
    public class FunctionalProgrammingTests
    {
        #region Referential Transparency

        [Test]
        public void Test()
        {
            var date = new DateTime(2018, 1, 18);
            var elapsedDays = CalculateElapsedDays(date);

            Assert.AreEqual(1, elapsedDays);
        }

        [Test]
        public void Test2()
        {
            var date = new DateTime(2018, 1, 18);
            var elapsedDays = CalculateElapsedDays2(date, DateTime.Now);

            Assert.AreEqual(1, elapsedDays);
        }

        public int CalculateElapsedDays(DateTime from)
        {
            DateTime now = DateTime.Now;
            return (now - from).Days;
        }

        public static int CalculateElapsedDays2(DateTime from, DateTime now)
            => (now - from).Days;

        #endregion

        #region Function Honesty

        [Test]
        public void Test3()
        {
            var result = Divide(1, 0);
        }

        [Test]
        public void Test4()
        {
            var result = Divide2(2, new NonZeroInt { Value = 0 });
        }

        public int Divide(int numerator, int denominator)
        {
            return numerator / denominator;
        }

        public static int Divide2(int numerator, NonZeroInt denominator)
        {
            return numerator / denominator.Value;
        }

        public class NonZeroInt
        {
            public int Value { get; internal set; }
        }

        #endregion

        #region Functions as first-class citizens

        [Test]
        public void Test5()
        {
            Func<int, bool> isMod2 = x => x % 2 == 0;
            var list = Enumerable.Range(1, 10);
            var evenNumbers = list.Where(isMod2);
        }

        #endregion

        #region Higher-order functions (HOF)

        [Test]
        public void Test6()
        {
            var list = new List<Entidad>
            {
                new Entidad { Value = "non-empty" },
                new Entidad(),
                new Entidad()
            };

            Func<Entidad, bool> HasValue = e => !string.IsNullOrEmpty(e.Value);

            var result = NonGeneric.Where<Entidad>(list, HasValue);
        }

        #endregion

        #region Pure Functions

        [Test]
        public void Test7()
        {
            var data = Enumerable.Range(1, 10).ToList();
            // var data = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var list = MultiplicationFormatter.Format(data);
            // var list = MultiplicationFormatter.Format(Enumerable.Range(1, 10).ToList());

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        #endregion
    }

    #region Higher-order functions (HOF)

    public class Entidad
    {
        public string Value { get; set; }
    }

    public static class NonGeneric
    {
        public static IEnumerable<T> Where<T>(IEnumerable<T> ts, Func<T, bool> predicate)
        {
            foreach (T t in ts)
            {
                if (predicate(t))
                {
                    yield return t;
                }
            }
        }
    }

    #endregion

    #region Pure Functions

    public static class Extensions
    {
        public static int MultiplyBy2(int value)
        {
            return value * 2;
        }
    }

    public static class MultiplicationFormatter
    {
        private static int counter;

        // private static string Counter(int val) => $"{++counter} x 2 = {val}";
        private static Func<int, string> Counter = r => $"{++counter} x 2 = {r}";

        public static List<string> Format(List<int> list)
            => list
            .Select(Extensions.MultiplyBy2)
            .Select(Counter)
            .ToList();
    }

    #endregion
}
