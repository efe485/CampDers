using System;
using System.Collections.Generic;
using System.Text;

namespace OOPThree
{
    class BasvuruManager
    {
        //Method injection 
        public void BasvuruYap(ICrediManager creditManager, ILoggerService loggerService)
        {
            creditManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<ICrediManager> krediler) //liste olarak bankadaki görevlinin seçtiği kredi türleri geliyor ve karsılıyoruz.
        {
            foreach (var kredi in krediler)//gelen listenin içerisinde dönüyoruz. 
            {
                kredi.Hesapla(); //döndüğü elemanın içerisinde seçtiğimiz kredi türünün hesapla fonksiyonunu çalıstırıyoruz.
            }
        }
    }
}
