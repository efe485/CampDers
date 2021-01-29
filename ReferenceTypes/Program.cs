using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Employe employe = new Employe();
            Person person1 = new Person();
            person1.name = "Efe";
            person1.lastName = "Bilgin";
            customer.name = "Hasan";
            PersonManager personManager = new PersonManager();
            personManager.Add(customer);
            

            Customer customer2 = new Customer();
            customer2 = customer;

            customer2.name = "Ali";
            Console.WriteLine(customer.name);



            Console.ReadKey();
        }

        class Customer:Person
        {
            public int cardNumber { get; set; }

        }
        class Person
        {
            public int id { get; set; }
            public string name { get; set; }
            public string lastName { get; set; }

        }
        class Employe:Person
        {
            public int employeeNumber { get; set; }
        }
        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.name);
            }
        }
    }
}
