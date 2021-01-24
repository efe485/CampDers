using System;

namespace OOPone
{
    class Program
    {
        static void Main(string[] args)
        {
            Product productOne = new Product();
            productOne.id = 1;
            productOne.categoryId = 2;
            productOne.productName = "Kitaplık";
            productOne.unitPrice = 600;
            productOne.unitsInStock = 4;

            Product productTwo = new Product {id = 2, categoryId = 5,unitsInStock = 2 , productName = "Silgi", unitPrice = 10 };
        }
    }
}
