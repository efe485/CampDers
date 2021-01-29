using System;

namespace ConstructorMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();//Burada tanımladığımız kurucu metodun defoult hali ile bir customer
            customer1.id = 2;
            customer1.name = "Halime";
            customer1.lastName = "Akıllı";


            Customer customer2 = new Customer(1, "Efe", "Bilgin");//buradaki customer ise kurucu metotdun asagıda tanımladığımız parametre alan hali.
        }
    }
    class Customer
    {
        //burada ise defaul olarak kurucu metotu overload ettik ki iki şekilde de kurucu metotu kullanabilelim. 
        public Customer()
        {

        }
        //kurucu metot olarak bunu yazdık
        public Customer(int id, string name, string lastName)
        {

        }
        public int id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
    }
}
