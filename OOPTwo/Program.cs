using System;

namespace OOPTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCustomer customer1 = new RealCustomer();
            customer1.id = 1;
            customer1.customerNumber = "12345";
            customer1.name = "Efe";
            customer1.lastName = "Bilgin";
            customer1.tcNo = "12345678900";


            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.id = 2;
            customer2.customerNumber = "4588";
            customer2.companyName = "Kodlama.io";
            customer2.taxNo = "889554";

            Customer customer3 = new RealCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer3);     //istediğimiz müsteriyi gönderebiliyoruz. 
            customerManager.Add(customer4);     //ister realCustomer tipinde bir customer olsun.
            customerManager.Add(customer1);     //ister Corparatecustemer tipinde bir customer olsun. 
            customerManager.Add(customer2);     //Cünkü CorparateCustomer sınıfı da RealCustomer sınıfıda customer sınıfından miras alıyor.
        }
    }
}
