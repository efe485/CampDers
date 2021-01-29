using System;
using System.Collections.Generic;
using System.Text;

namespace OOPThree
{
    class SmsLoggerService:ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms olarak loglandı");
        }
    }
}
