using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvester
{
    class Splitter
    {
        public static List<int> GetRowsAndCols(string s)
        {
            string[] values = s.Split(' ');

            List<int> valuesList = new List<int>();

            foreach(string value in values)
            {
                valuesList.Add(Convert.ToInt32(value));
            }
            

            return valuesList;
        }
    }
}
