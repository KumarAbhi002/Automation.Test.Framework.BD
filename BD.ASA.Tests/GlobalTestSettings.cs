using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.ASA.Tests
{
    [SetUpFixture]
    public class GlobalTestSettings
    {
        [OneTimeSetUp] 
        public void OneTimeSetup() 
        {
            Console.WriteLine(" global test settings OneTimeSetup ");

        }



        [OneTimeTearDown] 
        public void OneTimeTearDown() 
        {
            Console.WriteLine("global test settings OneTimeTearDown ");

        }
    }
}
