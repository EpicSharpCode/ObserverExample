using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample.News
{

    public class NewsAgency
    {
        public Random random = new Random();

        public delegate void NewsRecieveEventHandler(object sender, NewsEventArgs e);
        public event NewsRecieveEventHandler NewsRecieved;

        public List<NewsMessage> newsMessages;

        public NewsAgency()
        {
            newsMessages = new List<NewsMessage>();
        }

        public void MakeNewNews()
        {
            newsMessages.Add(new NewsMessage("Car Arrived",$"Car with number {random.Next(0,999999).ToString("D6")} was arrived"));
            NewsRecieve(newsMessages.Last());
        }

        public void NewsRecieve(NewsMessage newMessage)
        {
            if(NewsRecieved != null)
            {
                NewsRecieved(this, new NewsEventArgs(newMessage));
            }
        }
    }
}
