using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void SendSms(Customer customer)
        {
            Console.WriteLine("Sayın " + customer.Name + customer.Surname + " Limit Bilgileriniz Güncellenmiştir Şubelerimizden yada Internet Bankacılıgna giriş yaparak değişikliği onaylayabilirsiniz.");
        }

        public void ChangeLimit(Customer customer, int newLimit)
        {
            Console.WriteLine("Sayın " + customer.Name + customer.Surname + " Hesap Bilgileriniz : ");
            Console.WriteLine("Hesap Numaranız : " + customer.AccNumber);
            Console.WriteLine(customer.MaxLimit + " Olan Kredi Limitiniz : " + newLimit + " olarak güncellenmiştir.");
            SendSms(customer);
         }

        public void HesabıDondur(Customer customer)
        {
            DateTime bugun = DateTime.Now;
            Console.WriteLine(customer.AccNumber +" Numaralı Hesap "+ bugun +" itibariyle dondurulmuştur.");
        }


    }

}
