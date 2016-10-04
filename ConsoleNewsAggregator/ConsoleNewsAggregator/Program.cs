using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleNewsAggregator.Aggregators;

namespace ConsoleNewsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleFeed firstFeed = new SingleFeed();
            firstFeed.writeSingleFeed();
        }
    }
}
