using CreditCardMask;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreditCardMaskTests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void MaskifyTest()
        {
            Assert.AreEqual(Kata.Maskify("4556364607935616"), "############5616");
            Assert.AreEqual(Kata.Maskify("1"), "1");
            Assert.AreEqual(Kata.Maskify("11111"), "#1111");
        }
    }
}