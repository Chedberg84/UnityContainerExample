using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityExample
{
    class Shopper
    {
        public ICreditCard creditCard;

        public Shopper(ICreditCard cc)
        {
            this.creditCard = cc;
        }

        public int ChargesForCurrentCard
        {
            get
            {
                return creditCard.ChargeCount;
            }
        }

        public void Charge()
        {
            Console.WriteLine(creditCard.Charge());
        }
    }
}
