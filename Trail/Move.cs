using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trail
{
    public class Move
    {
        private string _s;
        private int _t;


        public Move(string s, int t)
        {
            _s = s;
            _t = t;
        }


        public string S
        {
            get
            {
                return _s;
            }

            set
            {
                _s = value;
            }
        }

        public int T
        {
            get
            {
                return _t;
            }

            set
            {
                _t = value;
            }
        }
    }
}
