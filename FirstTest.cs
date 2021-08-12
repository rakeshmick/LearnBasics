
using NUnit.Framework;

namespace Basics
{
   
    public class FirstTest
    {
        [Test]
        public void FirstTestMethod()
        {
            Assert.IsTrue(true);
        }
        [Test]
        public void SecondTestMethod()
        {
            Assert.IsTrue(false);
        }
    }
}
