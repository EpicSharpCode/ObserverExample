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
            newsMessages.Add(NewsMessageGenerator.GenerateNewsMessage());
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
