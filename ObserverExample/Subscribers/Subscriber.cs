using ObserverExample.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample.Subscribers
{
    internal class Subscriber : ISubscriber
    {
        public string name { get; private set; }
        List<INewsMessage> recievedMessages;

        public Subscriber(string _name)
        {
            recievedMessages = new List<INewsMessage>();
            name = _name;
        }

        public void Subscribe(NewsAgency newsAgency)
        {
            newsAgency.NewsRecieved += Update;
        }

        public void Update(object sender, NewsEventArgs e)
        {
            var message = e.newsMessage;
            recievedMessages.Add(message);
            Display(message);
        }
        public void Display(INewsMessage newsMessage)
        {
            Console.WriteLine($"[{name}] {newsMessage.OutputMessage()}");
        }
    }
}
