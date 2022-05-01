
using DataProvider;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC;
using System;
using System.Threading;

namespace ArchitectureUnitTests
{
    [TestClass]
    public class MVCUnitTests
    {
        [TestMethod]
        public void TestCheckRightBat()
        {
            Model model = new Model();
            Controller control = new Controller(null, model);
            control.SetBats(false, true);
            Assert.IsFalse(model.BatsLeft);
        }

        [TestMethod]
        public void TestCheckLeftBat()
        {
            Model model = new Model();
            Controller control = new Controller(null, model);
            control.SetBats(true, false);
            Assert.IsTrue(model.BatsLeft);
        }

        [TestMethod]
        public void TestCheckLeftThrow()
        {
            Model model = new Model();
            Controller control = new Controller(null, model);
            control.SetThrows(true, false);
            Assert.IsTrue(model.ThrowsLeft);
        }

        [TestMethod]
        public void TestCheckRightThrow()
        {
            Model model = new Model();
            Controller control = new Controller(null, model);
            control.SetThrows(false, true);
            Assert.IsFalse(model.ThrowsLeft);
        }
    }
}
