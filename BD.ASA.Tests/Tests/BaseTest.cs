using NUnit.Framework;
using System;

namespace BD.ASA.Tests.Tests
{
    [TestFixture]
    public class BaseTest
    {
        [SetUp]
        public void BaseTestSetup()
        {
            Console.WriteLine("this is BaseTestSetup");
        }

        [TearDown] 
        public void BaseTestTearDown() 
        {
            Console.WriteLine("this is BaseTestTearDown");

        }
    }
}
