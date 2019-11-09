using System;

namespace BankLib
{
    public class Konto
    {
        private string klient;  //nazwa klienta
        private decimal bilans;  //aktualny stan środków na koncie
        private bool zablokowane = false; //stan konta

        public string Nazwa => klient; // get, read-only
        public decimal Bilans => bilans; // get
        public bool Blokada => zablokowane; //get
        public Konto (string klient, decimal bilansNaStart = 0)
        {
            this.klient = klient;
            if (bilansNaStart < 0)
                throw new ArgumentOutOfRangeException("Kwota nie może być ujemna");

            this.bilans = bilansNaStart;
        }

        public void Wplata(decimal kwota) => throw new NotImplementedException();

        public void Wyplata(decimal kwota)
        {
            if (kwota < 0)
                throw new ArgumentOutOfRangeException("Kwota nie może być ujemna");
            bilans -= kwota;
        }

    }
}
