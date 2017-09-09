using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GwentRankingFeeder.Scraper
{
    public class RankingDataRow
    {
        public int Rank { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int Mmr { get; set; }
    }
}
