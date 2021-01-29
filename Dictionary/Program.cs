using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary'ler listeler gibi çalışır fakat tek farkı elemanları indis numarası ile değil key,value mantığı ile tutar.
            //örn
            Dictionary<int, string> dicList = new Dictionary<int, string>();
            dicList.Add(123, "Efe");
            dicList.Add(150, "Hasan");


            MyDictionary<int, string> diclist2 = new MyDictionary<int, string>();
            diclist2.Add(150, "EfeBilgin");
            diclist2.Add(180, "Harun");


            Console.WriteLine(diclist2["EfeBilgin"]);
        }
    }
}
