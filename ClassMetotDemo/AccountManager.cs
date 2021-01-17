using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class AccountManager
    {

        public int currentBalance { get; set; }
        public int accountLimit { get; set; }
        public int accMovement { get; set; }


        public void AccInformation(Customer customer)
        {
            Console.WriteLine("Sayın " + customer.Name +"Your Account Information : ");
            Console.WriteLine("Hesap Numaranız : " + customer.AccNumber);
            Console.WriteLine("Hesap Tutarı : " + currentBalance);
        }
    }
}
