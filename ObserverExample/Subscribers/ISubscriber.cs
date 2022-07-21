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
        void Update(object sender, NewsEventArgs e);
        void Subscribe(NewsAgency newsAgency);
    }
}
