using ObserverExample.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample.Subscribers
{
    public class Subscriber : ISubscriber
    {
        string subscriberID;
        List<INewsMessage> recievedMessages;

        public Subscriber()
        {
            recievedMessages = new List<INewsMessage>();
        }

        private void GenerateSubscriberID()
        {
            Random random = new Random();
            subscriberID = random.Next(0, 999999999).ToString("D9");
        }

        public void Subscribe(NewsAgency newsAgency)
        {
            newsAgency.NewsRecieved += RecieveNews;
        }

        public void RecieveNews(object sender, NewsEventArgs e)
        {
            recievedMessages.Add(e.newsMessage);
            Output(e.newsMessage);
        }
        public virtual void Output(INewsMessage newsMessage)
        {
            Console.WriteLine($"Subscriber {subscriberID} get message: {newsMessage.OutputMessage()}");
        }
    }
}
