using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.urunAd = "Elma";
            urun1.urunFiyat = 15;
            urun1.urunAciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.urunAd = "Çilek";
            urun2.urunFiyat = 15;
            urun2.urunAciklama = "Kıpkırmızı çilek";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun item in urunler)
            {
                Console.WriteLine("Urun Adı: " + item.urunAd);
                Console.WriteLine("Fiyatı : " + item.urunFiyat);
                Console.WriteLine("Urun Acıklama: " + item.urunAciklama+"\n\n");
            }
            //Bunun alt tarafı encapsulation olarak isimlendiriliyor. 
            //Yani parametre olarak verdiğimiz classın özelliklerini kapsulden cıkartıyoruz.
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
        }
    }
}
