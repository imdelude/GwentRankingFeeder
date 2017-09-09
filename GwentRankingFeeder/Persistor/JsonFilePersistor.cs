using System;
using GwentRankingFeeder.Scraper;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace GwentRankingFeeder
{
    public class JsonFilePersistor : IRankingDataPersistor
    {
        private string _path;
        private string _fileName;

        private string CombinedPath => Path.Combine(_path, _fileName);

        public JsonFilePersistor(string path, string fileName)
        {
            _path = path;
            _fileName = fileName;
        }

        public bool Save(List<RankingDataRow> data)
        {
            try
            {
                var jsonString = JsonConvert.SerializeObject(data);
                File.WriteAllText(CombinedPath, jsonString);

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}