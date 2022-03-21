using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianCenuseStateAnalyzer
{
    public class CensuseAnalyzer
    {
        public enum Country
        {
            INDIA,BRAZIL,US,ARGENTINA,VUTAN
        }
        Dictionary<String, Censuse> dataMap;

        public Dictionary<String, Censuse> LoadCensusDataMap(Country country, string csvfilePath, string dataheaders)
        {
            CSVDataReader cSVDataReader = new CSVDataReader();
            cSVDataReader.readfromcsv(csvfilePath, country);
        }
        

    }
}
