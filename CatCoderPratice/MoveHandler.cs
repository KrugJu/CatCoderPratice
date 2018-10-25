using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCoderPratice
{
    static class MoveHandler
    {
        public static void ApplyMove(List<Block> blocks, int[] move)
        {
            foreach (Block b in blocks)
            {
                if (b.id == move[0])
                {
                    if (b.orientation == 'h') b.x += move[1];
                    else b.y += move[1];
                }
            }
        }
    }
}
