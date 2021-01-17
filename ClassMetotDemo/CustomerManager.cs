using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        string kapatmaSms = "Hesabınız Kapatılmış yada askıya alınmıştır bilgi almak için 444 0 444 ü arayabilirsiniz.";
        string yukseltmeSms = "Limitiniz Yükseltilmiştir Şubelerimizden yada Internet Bankacılıgna giriş yaparak değişikliği kontrol edebilirsiniz.";
        string dusurmeSms = "Limitiniz Düşürme Talebinize istinaden Kredi Limitiniz Düşürülmüştür. Şubelerimizden yada Internet Bankacılıgna giriş yaparak değişikliği kontrol edebilirsiniz.";

        public void SendSms(Customer customer, string mesaj)
        {
            Console.WriteLine("Sayın " + customer.Name + customer.Surname + mesaj);
        }

        public void ChangeLimit(Customer customer, int newLimit)
        {
            Console.WriteLine("Sayın " + customer.Name + customer.Surname + " Hesap Bilgileriniz : ");
            Console.WriteLine("Hesap Numaranız : " + customer.AccNumber);
            Console.WriteLine(customer.MaxLimit + " Olan Kredi Limitiniz : " + newLimit + " olarak güncellenmiştir.");
            if (customer.MaxLimit < newLimit)
            {
                SendSms(customer, yukseltmeSms);
            }
            else
            {
                SendSms(customer, dusurmeSms);
            }

         }

        public void HesabıDondur(Customer customer)
        {
            DateTime bugun = DateTime.Now;
            Console.WriteLine(customer.AccNumber +" Numaralı Hesap "+ bugun +" itibariyle dondurulmuştur.");
            customer.MaxLimit = 0;
            Console.WriteLine("Hesap Limit Bilgisi : " + customer.MaxLimit);
            SendSms(customer, kapatmaSms);
        }


    }

}
