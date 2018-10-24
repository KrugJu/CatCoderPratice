using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCoderPratice
{
    static class Checker
    {
        public static bool CheckForInterception (Block b1, Block b2)
        {
            int b1x = b1.x;
            int b1y = b1.y;
            int b2x = b2.x;
            int b2y = b2.y;

            for(int i = 0; i < b1.length; i++)
            {
                for(int j = 0; j < b2.length; j++)
                {
                    if (b1x == b2x && b1y == b2y) return true;

                    if(b2.orientation == 'h')
                    {
                        b2x++;
                    }
                    else if(b2.orientation == 'v')
                    {
                        b2y++;
                    }
                }


                if(b1.orientation == 'h')
                {
                    b1x++;
                }
                else if(b1.orientation == 'v')
                {
                    b1y++;
                }

                b2x = b2.x;
                b2y = b2.y;

            }

            return false;
        }

    }
}
