using ObserverExample.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample.Subscribers
{
    public interface ISubscriber
    {
        void RecieveNews(object sender, NewsEventArgs e);
        void Subscribe(NewsAgency newsAgency);
        void Output(INewsMessage newsMessage);
    }
}
