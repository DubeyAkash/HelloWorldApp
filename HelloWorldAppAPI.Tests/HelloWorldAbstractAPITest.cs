using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldAppAPI.Tests
{
    [TestClass]
    class HelloWorldAbstractAPITest
    {
        [TestMethod]
        public void SetConsoleMessage()
        {
            HelloWorldConsole hwc = new HelloWorldConsole();

            hwc.SetConsoleMsg("Hello World");

            //verify if HelloWorldConsole object is not null
            Assert.IsNotNull(hwc);

            //verify if both the objects are equal
            Assert.AreEqual("Hello World", hwc.consoleMsg);
        }

        [TestMethod]
        public void SetDatabaseMessage()
        {
            HelloWorldDatabase hwd = new HelloWorldDatabase();
            hwd.SetConsoleMsg("Hello World");

            Assert.IsNotNull(hwd);

            Assert.AreEqual("Hello World", hwd.consoleMsg);
        }
    }
}
