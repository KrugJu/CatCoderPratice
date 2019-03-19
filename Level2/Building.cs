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
        List<Position> blocks;

        public Building(int id)
        {
            this.id = id;
        }

        public Building(int id, int area, List<Position> blocks) : this(id)
        {
            this.area = area;
            this.blocks = blocks;
        }


        public Position getCentroid()
        {
            double x = 0;
            double y = 0;

            foreach(Position block in blocks)
            {
                x += block.i + 0.5;
                y += block.j + 0.5;
            }

            x = Math.Ceiling(x/area);
            y = Math.Ceiling(y/area);

            return new Position(Convert.ToInt32(x),Convert.ToInt32(y));
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

        public List<Position> Blocks
        {
            get
            {
                return blocks;
            }

            set
            {
                blocks = value;
            }
        }
    }
}
