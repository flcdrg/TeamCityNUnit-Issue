using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace TeamCityNUnit
{
    [TestFixture]
    [Category("Special")]
    public class UnitTest1
    {
        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            Console.WriteLine("Inside TestFixtureSetUp");    
        }

        [Test]
        public void TestMethod1()
        {
        }

        [Test]
        [Explicit("This is explicit")]
        public void ShouldBeExplicit()
        {
            
        }
    }
}
