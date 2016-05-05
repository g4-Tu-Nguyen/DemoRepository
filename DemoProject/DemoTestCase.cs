using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoProject
{
    [TestClass]
    public class DemoTestCase
    {
        [TestMethod]
        public void Member1_TestMethod1()
        {
            Console.WriteLine("..");
        }
        public void NewFunc()
        {
            Console.WriteLine("Huong Huynh");
        }
        public void Member1_TestMethod1()
        {
            Console.WriteLine("Hello member 2!");
        }
        public void Greeting_TestCase()
        {
            Console.WriteLine("Hello member 2!");
            Console.WriteLine("jdfhgdfjkgkdf");
            Console.WriteLine("I am member 1!");
        }
    }
}
