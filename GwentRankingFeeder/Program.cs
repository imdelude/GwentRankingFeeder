using GwentRankingFeeder.Scraper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GwentRankingFeeder
{
    class Program
    {
        static void Main(string[] args)
        {
            IRankingScraper scraper = new SimpleRankingScraper();
            IRankingDataPersistor persistor = new JsonFilePersistor("../Content/", "rankingData.json");
            var result = scraper.Scrape(1000);
            persistor.Save(result);
            Console.ReadLine();
        }
    }
}
