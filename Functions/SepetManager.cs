using System;
using System.Collections.Generic;
using System.Text;

namespace Functions
{
    class SepetManager
    {
        //convention
        public void Ekle(Urun urun) //neden burada class tipinden bir değer verdik. Buraya string urunAdi sekliden ekleme de yapabilirdik. Ama neden class tipinde bir parametre ekledik. Cünkü yönetim gelip bir parametre daha ekleyelim derse her yerde tek tek bu metodu cagırdığın yerlere gidip parametreleri vermek zorundasın. 
        {
            Console.WriteLine("Sepete Eklendi : " + urun.urunAd);
        }
    }
}
