using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etl.exercism.io
{
    public class ETL
    {
        Dictionary<int, IList<string>> oldScore;

        public Dictionary<string, int> Transform(Dictionary<int, IList<string>> score)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            
            foreach(KeyValuePair<int, IList<string>> dictEntry in score)
            {
                int numValue = dictEntry.Key;
                
                foreach (string strValue in dictEntry.Value)
                {
                    result.Add(strValue.ToLower(), numValue);
                }
            }

            return result;
        }
    }
}
