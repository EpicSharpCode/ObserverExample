using ObserverExample.News;
using ObserverExample.Subscribers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewsAgency newsAgency = new NewsAgency();
            var subscriber1 = new SubscriberPerson("JohnBates");
            subscriber1.Subscribe(newsAgency);
            newsAgency.MakeNewNews();
            OutputEmptyLine();
            var subscriber2 = new SubscriberPerson("SarahPage");
            subscriber2.Subscribe(newsAgency);
            newsAgency.MakeNewNews();
            OutputEmptyLine();
            var subscriber3 = new SubscriberPerson("William87");
            subscriber3.Subscribe(newsAgency);
            newsAgency.MakeNewNews();
            OutputEmptyLine();
            var subscriberOrg1 = new SubscriberOrganization("Langman Buro");
            subscriberOrg1.Subscribe(newsAgency);
            newsAgency.MakeNewNews();

            Console.ReadKey();
        }


        public static void OutputEmptyLine() => Console.WriteLine();
    }
}
