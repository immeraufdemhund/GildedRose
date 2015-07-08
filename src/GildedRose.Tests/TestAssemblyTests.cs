using FluentAssertions;
using NUnit.Framework;

namespace GildedRose.Tests
{
    [TestFixture]
    public class TestAssemblyTests
    {
        [Test]
        public void TestTheTruth()
        {
            true.Should().BeTrue();
        }
    }
}