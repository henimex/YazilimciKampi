using System;

namespace ConstructorYapisiDers
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1,"Ferhat","Oygur","Eskişehir");
            Customer customer2 = new Customer { ID = 1, City = "Eskişehir", FirstName = "Dilek", SurName = "Oygur" };

            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer.FirstName);
        }
    }

    class Customer
    {
        public Customer(int id, string name, string surname, string city)
        {
            Console.WriteLine("Constructor Olusturuldu {0}", name);

            ID = id;
            FirstName = name;
            SurName = surname;
            City = city;
        }

        public Customer()
        {

        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string City { get; set; }
    }
}
