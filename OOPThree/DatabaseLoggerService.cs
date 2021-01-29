using System;
using System.Collections.Generic;
using System.Text;

namespace OOPThree
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
