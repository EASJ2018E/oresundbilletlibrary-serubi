using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBilletLibrary;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOresundBilPris()
        {
            // Arrange
            OresundBil bil = new OresundBil("1234", DateTime.Now);

            // Act
            decimal pris = bil.Pris();

            // Assert
            Assert.AreEqual(410, pris);
        }

        [TestMethod]
        public void TestOresundBilPrisBrobizz()
        {
            // Arrange
            OresundBil bil = new OresundBil("1234", DateTime.Now, true);

            // Act
            decimal pris = bil.Pris();

            // Assert
            Assert.AreEqual(161, pris);
        }

        [TestMethod]
        public void TestOresundBilNavn()
        {
            // Arrange
            OresundBil bil = new OresundBil("1234", DateTime.Now, false);

            // Act
            string navn = bil.K�ret�j();

            // Assert
            Assert.AreEqual("�resund Bil", navn);
        }

        [TestMethod]
        public void TestOresundMCPris()
        {
            // Arrange
            OresundMotorcykel mc = new OresundMotorcykel("1234", DateTime.Now);

            // Act
            decimal pris = mc.Pris();

            // Assert
            Assert.AreEqual(210, pris);
        }

        [TestMethod]
        public void TestOresundMCPrisBrobizz()
        {
            // Arrange
            OresundMotorcykel mc = new OresundMotorcykel("1234", DateTime.Now, true);

            // Act
            decimal pris = mc.Pris();

            // Assert
            Assert.AreEqual(73, pris);
        }

        [TestMethod]
        public void TestOresundMCNavn()
        {
            // Arrange
            OresundMotorcykel mc = new OresundMotorcykel("1234", DateTime.Now, false);

            // Act
            string navn = mc.K�ret�j();

            // Assert
            Assert.AreEqual("�resund MC", navn);
        }
    }
}
