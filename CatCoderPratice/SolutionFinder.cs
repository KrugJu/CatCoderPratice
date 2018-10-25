using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCoderPratice
{
    static class SolutionFinder
    {
        public static List<bool> FindAllSolutions(string[] inputs)
        {
            List<bool> outputs = new List<bool>();

            foreach (string input in inputs)
            {
                List<Block> blocks = Splitter.SplitIntoBlocks(input);
                int[] move = Splitter.GetMove(input);
                MoveHandler.ApplyMove(blocks, move);
                int[] grid = Splitter.GetGrid(input);

                List<Block> interceptingBlocks = TestAllBlocks.CheckForMatches(blocks, grid[0], grid[1]);
                if (interceptingBlocks.Count == 0) outputs.Add(false);
                else outputs.Add(true);
            }

            return outputs;
        }
    }
}
