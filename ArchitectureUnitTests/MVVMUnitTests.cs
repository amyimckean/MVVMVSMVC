

using DataProvider;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ArchitectureUnitTests
{
    [TestClass]
    public class MVVMUnitTests
    {
        [TestMethod]
        public void TestCheckRightBat()
        {
            Model model = new Model();
            model.BatsLeft = true;
            ViewModel vm = new ViewModel(model);
            vm.OnBatsChange(null);
            Assert.IsFalse(model.BatsLeft);
        }

        [TestMethod]
        public void TestCheckLeftBat()
        {
            Model model = new Model();
            model.BatsLeft = false;
            ViewModel vm = new ViewModel(model);
            vm.OnBatsChange(null);
            Assert.IsTrue(model.BatsLeft);
        }

        [TestMethod]
        public void TestCheckLeftThrow()
        {
            Model model = new Model();
            model.ThrowsLeft = false;
            ViewModel vm = new ViewModel(model);
            vm.OnThrowsChange(null);
            Assert.IsTrue(model.ThrowsLeft);
        }

        [TestMethod]
        public void TestCheckRightThrow()
        {
            Model model = new Model();
            model.ThrowsLeft = true;
            ViewModel vm = new ViewModel(model);
            vm.OnThrowsChange(null);
            Assert.IsFalse(model.ThrowsLeft);
        }
    }
}
