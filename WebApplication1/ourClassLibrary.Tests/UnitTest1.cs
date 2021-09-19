using NUnit.Framework;

namespace ourClassLibrary.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void verifyAddTen()
        {
            var value = 2102;
            var result = ourClassLibrary.Class1.AddTen(value);
        }
    }
}