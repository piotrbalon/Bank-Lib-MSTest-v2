using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankLib;

namespace UnitTestBank
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow("mol", 1000)]
        [DataRow("abc", 100.23)]
        [DataRow("aaa", 0)]
        public void Konstruktor_PoprawneDane_PoprawneWyniki(string klient, double kwota)
        {
            // Arrange
            //string klient = "kowalski";
            //decimal kwota = 1000;

            // Act
            Konto k = new Konto(klient, (decimal)kwota);

            // Assert
            Assert.AreSame(klient, k.Nazwa);
            Assert.AreEqual((decimal)kwota, k.Bilans);
            Assert.IsTrue(k.Bilans >= 0);

        }


        [DataTestMethod]
        [DataRow("mol", -100)]
        [DataRow("mol", -0.00000000001)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Konstruktor_UjemnaKwota_Wyjatek(string klient, double kwota)
        {
            // Act
            Konto k = new Konto(klient, (decimal)kwota);
            // powinien być zgłoszony wyjątek
        }
    }
}
