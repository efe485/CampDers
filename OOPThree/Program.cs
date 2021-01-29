using System;
using System.Collections.Generic;

namespace OOPThree
{
    class Program
    {
        static void Main(string[] args)
        {
            ICrediManager vehicleCreditManager = new VehicleCreditManager();
            ICrediManager personelFinanceCreditManager = new PersonelFinanceCreditManager();
            ICrediManager housingCreditManager = new HousingCreditManager();
            ICrediManager artisanCreditManager = new ArtisanCreditManager();


            BasvuruManager basvuruManager = new BasvuruManager();

            basvuruManager.BasvuruYap(vehicleCreditManager, new DatabaseLoggerService());//buraları yukarıdada newleyebilirdik.
            basvuruManager.BasvuruYap(housingCreditManager, new FileLoggerService()); //buraları yukarıdada newleyebilirdik.
            basvuruManager.BasvuruYap(artisanCreditManager, new SmsLoggerService());

            List<ICrediManager> krediler = new List<ICrediManager>() { vehicleCreditManager};
            krediler.Add(personelFinanceCreditManager);

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
