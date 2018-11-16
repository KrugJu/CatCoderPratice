using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    public class Building
    {
        int id;
        int area;

        public Building(int id, int area)
        {
            this.id = id;
            this.area = area;
        }


        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int Area
        {
            get
            {
                return area;
            }

            set
            {
                area = value;
            }
        }
    }
}
