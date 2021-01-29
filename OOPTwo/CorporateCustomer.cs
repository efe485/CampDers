using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTwo
{
    class CorporateCustomer : Customer//Tüzel Müşteri
    {
        public string companyName { get; set; }
        public string taxNo { get; set; } //vergi No:
    }
}
