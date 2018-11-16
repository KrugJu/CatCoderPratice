using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trail
{
    public static class Processor
    {

        public static List<int> processAllInputs(List<string> inputs)
        {
            List<int> outputs = new List<int>();

            foreach(string input in inputs)
            {
                List<Move> moves = Splitter.SplitIntoMoves(input);
                outputs.Add(Mover.calcMoveLength(moves));
                outputs.Add(Mover.calcArea(moves));
                outputs.Add(Mover.calcPolygonArea(moves));
            }

            return outputs;
        }
    }
}
