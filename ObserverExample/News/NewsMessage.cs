using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample.News
{
    public class NewsMessage : INewsMessage
    {
        public string newsTitle { get; private set; }
        public string newsText { get; private set; }


        public NewsMessage(string _newsTitle, string _newsText)
        {
            newsTitle = _newsTitle;
            newsText = _newsText;
        }
        public NewsMessage(NewsMessage _message)
        {
            newsTitle = _message.newsTitle;
            newsText = _message.newsText;
        }

        public string OutputMessage() => $"{newsTitle} - {newsText}";
    }
}
