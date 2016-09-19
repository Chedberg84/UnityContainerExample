using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityExample
{
    class Visa : ICreditCard
    {
        public string Charge()
        {
            return "Visa";
        }

        public int ChargeCount
        {
            get { return 0; }
        }
    }
}
