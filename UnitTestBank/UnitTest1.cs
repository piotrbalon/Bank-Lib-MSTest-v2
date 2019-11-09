using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankLib;

namespace UnitTestBank
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string klient = "kowalski";
            decimal kwota = 1000;

            //Act
            Konto k = new Konto(klient, kwota);

            //Assert
            Assert.AreSame(klient, k.Nazwa);
            Assert.AreEqual(kwota, k.Bilans);
            Assert.IsTrue(k.Bilans >= 0);

        }
    }
}
