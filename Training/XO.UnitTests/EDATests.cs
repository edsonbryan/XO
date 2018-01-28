using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO.UnitTests
{
    [TestFixture]
    public class EDATests
    {
        [Test]
        public void Test()
        {
            var countdown = new Countdown();

            countdown.Decrement();
        }
    }
    
    public class Countdown
    {
        private int internalCounter { get; set; }

        public event EventHandler CountdownCompleted;

        protected virtual void OnCountdownCompleted(EventArgs e)
        {
            if (CountdownCompleted != null)
                CountdownCompleted(this, e);
        }

        public void Decrement()
        {
            internalCounter--;
            if (internalCounter == 0)
                OnCountdownCompleted(new EventArgs());
        }
    }
}
