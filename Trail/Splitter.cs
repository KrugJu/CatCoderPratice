using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trail
{
    public static class Splitter
    {

        public static List<Move> SplitIntoMoves(string text)
        {
            string[] moves = text.Split(' ');

            List<Move> moveList = new List<Move>();
            for (int i = 1; i < moves.Length; i += 2)
            {
                moveList.Add(new Move(moves[i], Convert.ToInt32(moves[i + 1])));
            }

            return moveList;

        }
    }
}
