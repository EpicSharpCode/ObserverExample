using ObserverExample.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample.Subscribers
{
    internal class SubscriberOrganization : Subscriber
    {
        string organizationName;
        public SubscriberOrganization(string _organizationName) : base()
        {
            organizationName = _organizationName;
        }

        public override void Output(INewsMessage newsMessage)
        {
            Console.WriteLine($"Organization [{organizationName}] get message: " +
                $"{newsMessage.OutputMessage()}");
        }
    }
}
