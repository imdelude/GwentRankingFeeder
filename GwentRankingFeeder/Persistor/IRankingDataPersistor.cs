using GwentRankingFeeder.Scraper;
using System.Collections.Generic;

namespace GwentRankingFeeder
{
    internal interface IRankingDataPersistor
    {
        bool Save(List<RankingDataRow> data);
    }
}