using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranking
{
    public class User
    {
        private int uid;
        private int points = 0;

        public int Uid
        {
            get
            {
                return uid;
            }

            set
            {
                uid = value;
            }
        }

        public int Points
        {
            get
            {
                return points;
            }

            set
            {
                points = value;
            }
        }

        public User(int uid)
        {
            this.uid = uid;
        }

    }
}
