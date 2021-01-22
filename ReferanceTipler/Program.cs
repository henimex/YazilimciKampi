using System;

namespace ReferanceTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;

            sayi2 = 100;
            Console.WriteLine(sayi1); //20

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 100, 200, 300 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine(sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirsName = "Ferhat";
            person2.FirsName = "Dilek";

            //Onemli 1
            person2 = person1;
            person1.FirsName = "Esila";

            Console.WriteLine(person2.FirsName);
            //Onemli 1
            
            Customer customer = new Customer();
            customer.FirsName = "Ali Alp";

            Employee employee = new Employee();
            employee.FirsName = "Cemil";

            Person person3 = customer;
            Console.WriteLine(person3.FirsName);
            Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager pm = new PersonManager();
            pm.Add(person3);
            pm.Add(employee);

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string Surname { get; set; }
    }

    class Customer: Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirsName);
        }

    }
}
