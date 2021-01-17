using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountManager acm = new AccountManager();
            CustomerManager cm = new CustomerManager();

            Customer customer1 = new Customer();
            customer1.id = 1;
            customer1.Name = "Ferhat";
            customer1.Surname = "Oygur";
            customer1.AccNumber = 984812154;
            customer1.MaxLimit = 10000;

            Customer customer2 = new Customer();
            customer2.id = 2;
            customer2.Name = "Dilek";
            customer2.Surname = "Oygur";
            customer2.AccNumber = 156763211;
            customer2.MaxLimit = 15000;

            Customer customer3 = new Customer();
            customer3.id = 3;
            customer3.Name = "Esila";
            customer3.Surname = "Oygur";
            customer3.AccNumber = 120054105;
            customer3.MaxLimit = 1500;

            Customer customer4 = new Customer();
            customer4.id = 4;
            customer4.Name = "Ali Alp";
            customer4.Surname = "Oygur";
            customer4.AccNumber = 1468410654;
            customer4.MaxLimit = 1000;

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };

            Console.WriteLine("Toplam müşteri sayısı : " + customers.Length);
            Console.WriteLine("Müşteriler : -----------\n");

            foreach (Customer x in customers)
            {
                Console.WriteLine(x.Name + " " + x.Surname +  " \t("+x.MaxLimit+")");
            }
            Console.WriteLine("Müşteriler : -----------\n");

            cm.ChangeLimit(customer1, 11000);

            cm.HesabıDondur(customer2);
        }
    }
}
