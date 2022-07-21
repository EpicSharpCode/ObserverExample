using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample.News
{
    public static class NewsMessageGenerator
    {
        private static Random random = new Random();
        public enum NewsType
        {
            CarArrive,
            PeopleMerge,
            PeopleArrived
        }

        public static List<string> cityLocations { get; private set; } = new List<string>()
        {
            "City Hall",
            "Mall",
            "Elementary School",
            "College"
        };

        public static NewsMessage GenerateNewsMessage()
        {
            var newsType = (NewsType)random.Next(0, 3);
            switch (newsType)
            {
                case NewsType.CarArrive:
                    {
                        return new NewsMessage("Car Arrived", $"Car with number {random.Next(0, 999999).ToString("D6")} was arrived to {cityLocations[random.Next(0,cityLocations.Count)]}");
                    }
                case NewsType.PeopleMerge:
                    {
                        return new NewsMessage("People Merge", $"{random.Next(0, 150)} was merged from the city");
                    }
                case NewsType.PeopleArrived:
                    {
                        return new NewsMessage("People Arrived", $"{random.Next(0, 250)} was arrived to the city");
                    }
            }
            return null;
        }
    }
}
