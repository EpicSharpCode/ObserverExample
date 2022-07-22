using ObserverExample.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample.Subscribers
{
    public class SubscriberPerson : Subscriber
    {
        public string name { get; private set; }

        public SubscriberPerson(string name) : base()
        {
            this.name = name;
        }

        public override void Output(INewsMessage newsMessage)
        {
            Console.WriteLine($"User [{name}] get message: {newsMessage.OutputMessage()}");
        }
    }
}
