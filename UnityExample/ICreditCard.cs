using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityExample
{
    interface ICreditCard
    {
        string Charge();
        int ChargeCount { get; }
    }
}
