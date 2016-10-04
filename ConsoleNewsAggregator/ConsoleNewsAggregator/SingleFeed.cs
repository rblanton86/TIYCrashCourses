using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.Xml;

namespace ConsoleNewsAggregator.Aggregators
{
    class SingleFeed
    {
        public SingleFeed()
        { }

        public void writeSingleFeed()
        {
            string url = "https://visualstudiomagazine.com/rss-feeds/practical-net.aspx";
            using (XmlReader reader = XmlReader.Create(url))
            {
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                Console.WriteLine(feed.Title.Text);
                Console.WriteLine(feed.Links[0].Uri);
                foreach (SyndicationItem item in feed.Items)
                {
                    Console.WriteLine(item.Title.Text);
                    Console.WriteLine(item.PublishDate.Date);
                    Console.WriteLine(item.Links[0].Uri + Environment.NewLine);
                }
            }

            Console.ReadLine();
        }
    }
}
