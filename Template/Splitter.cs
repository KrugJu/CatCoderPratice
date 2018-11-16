using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public static class Splitter
    {
        public static List<int> SplitIntoBuildings(string s)
        {
            string[] values = s.Split(' ', '\n');

            List<int> valuesList = new List<int>();

            for(int i = 2; i < values.Length; i++)
            {
                valuesList.Add(Convert.ToInt32(values[i]));
            }
                      
            return valuesList;
        }
    }
}
