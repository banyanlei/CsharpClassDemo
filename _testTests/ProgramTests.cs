using Microsoft.VisualStudio.TestTools.UnitTesting;
using _test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _test.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest()
        {
            string deviceType, val;
            Assert.IsTrue(Program.Add(1, 2, 3) == 3);
            Assert.IsTrue(Program.RunAisgDeviceScan(out deviceType) == "world");
        }

        [TestMethod()]
        public void MainTest1()
        {
            string deviceType, val;
            Assert.IsTrue(Program.Add(1, 2, 3) == 3);
            Assert.IsTrue(Program.RunAisgDeviceScan(out deviceType) == "world1");
        }
    }
}