using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GwentRankingFeeder.Scraper
{
    interface IRankingScraper
    {
        List<RankingDataRow> Scrape(int numberOfRanks);
    }
}
