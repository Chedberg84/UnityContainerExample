using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityExample
{
    class MasterCard : ICreditCard
    {
        public string Charge()
        {
            ChargeCount++;
            return "Charging with MasterCard.";
        }
        public int ChargeCount { get; set; }
    }
}
