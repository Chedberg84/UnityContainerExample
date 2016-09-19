using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;

namespace UnityExample
{
    public class MainProgram
    {
        public static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<ICreditCard, MasterCard>();

            //singleton construction for mastercard
            //container.RegisterType<ICreditCard, MasterCard>(new ContainerControlledLifetimeManager());

            //property injection on registration
            //container.RegisterType<ICreditCard, MasterCard>(new InjectionProperty("ChargeCount", 5));

            //constructor injection on registration
            //container.RegisterType<ICreditCard, MasterCard>(new InjectionConstructor(""));

            //MasterCard card = new MasterCard();
            //container.RegisterInstance(card);



            //Override a registered parameter
            var shopper = container.Resolve<Shopper>(new ParameterOverride("cc", new Visa()));

            shopper.Charge();

            Console.Read();
        }
    }
}
