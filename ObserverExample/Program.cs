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
            Subscriber subscriber1 = new Subscriber("JohnBates");
            subscriber1.Subscribe(newsAgency);
            newsAgency.MakeNewNews();
            OutputEmptyLine();
            Subscriber subscriber2 = new Subscriber("SarahPage");
            subscriber2.Subscribe(newsAgency);
            newsAgency.MakeNewNews();
            OutputEmptyLine();
            Subscriber subscriber3 = new Subscriber("William87");
            subscriber3.Subscribe(newsAgency);
            newsAgency.MakeNewNews();

            Console.ReadKey();
        }


        public static void OutputEmptyLine() => Console.WriteLine();
    }
}
