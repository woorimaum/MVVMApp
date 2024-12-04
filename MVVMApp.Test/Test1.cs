using MVVMApp.Core;

namespace MVVMApp.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestIncrement()
        {
            MainViewModel mainViewModel = new();

            Assert.AreEqual(0, mainViewModel.Counter);

            mainViewModel.Increment();

            Assert.AreEqual(1, mainViewModel.Counter);
        }

        [TestMethod]
        public void TestDecrement() 
        { 
            MainViewModel mainViewModel = new();

            Assert.AreEqual(0, mainViewModel.Counter);            

            mainViewModel.Decrement();

            Assert.AreEqual(-1, mainViewModel.Counter);
        }
    }
}
