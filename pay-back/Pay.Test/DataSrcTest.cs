using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pay.API.Data;
using Pay.API.Interfaces;
using System.Threading.Tasks;

namespace Pay.Test
{
    [TestClass]
    public class DataSrcTest
    {
        private IDataSrc? _daraSrc;

        [TestInitialize()]
        public void Setup()
        {
            _daraSrc = new DataSrc();
        }

        [TestCleanup()]
        public void Cleanup()
        {
        }

        [TestMethod]
        public async Task ShouldReturnTrue()
        {
            string test = "bob";
            bool result = await _daraSrc.IsPalindrome(test);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public async Task ShouldReturnWithCaseTrue()
        {
            string test = "Bob";
            bool result = await _daraSrc.IsPalindrome(test);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public async Task ShouldReturnWithLongTrue()
        {
            string test = "racecar";
            bool result = await _daraSrc.IsPalindrome(test);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public async Task ShouldReturnWithPhraseFalse()
        {
            string test = "race car";
            bool result = await _daraSrc.IsPalindrome(test);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public async Task ShouldReturnWithWhiteSpaceFalse()
        {
            string test = "Bo b";
            bool result = await _daraSrc.IsPalindrome(test);
            Assert.AreEqual(false, result);
        }
    }
}