using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public static class Processor
    {

        public static int TestForBuilding(List<int> values)
        {
            values = new List<int>();
            List<int> buildings = values.Where(x => x > 0).ToList();
            if (buildings.Count > 0) return 1;
            else return 0;
        }
    }
}
