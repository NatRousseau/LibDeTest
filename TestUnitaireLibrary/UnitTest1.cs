using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_Unitaire;

namespace TestUnitaireLibrary
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(MaSuperClass.Multiplier(42), 84);
        }
    }
}