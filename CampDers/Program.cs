using System;

namespace CampDers
{
    class Program
    {
        static void Main(string[] args)
        {
            Products ürün1 = new Products();
            ürün1.price = 15;
            ürün1.productName = "Karpuz";
            ürün1.productDescription = "Karpuz gibi karpuz";
            ürün1.id = new Guid();

            Products ürün2 = new Products();
            ürün2.price = 20;
            ürün2.productName = "Elma";
            ürün2.productDescription = "Amasya Elması";

            Products ürün3 = new Products();
            ürün3.price = 30;
            ürün3.productDescription = "Portakal acıklama";
            ürün3.productName = "portakal";

            Products[] ürünler = new Products[] { ürün1, ürün2, ürün3};

            foreach (Products item in ürünler)
            {
                Console.WriteLine(item.id);
                Console.WriteLine(item.productName);
                Console.WriteLine(item.productDescription);
                Console.WriteLine(item.price);
            }


            Console.ReadKey();
        }
    }
}
