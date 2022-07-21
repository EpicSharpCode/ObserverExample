using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample.News
{
    public class NewsEventArgs
    {
        public INewsMessage newsMessage { get; private set; }

        public NewsEventArgs(NewsMessage _newsMessage)
        {
            newsMessage = new NewsMessage(_newsMessage);
        }
    }
}
