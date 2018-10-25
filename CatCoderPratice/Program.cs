using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCoderPratice
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.IO.StreamReader myFile = new System.IO.StreamReader("C:\\Users\\Berger Elias\\Downloads\\lvl1.inp");
            string text = "0 v 3 3 2 1 v 3 5 2";
            //text = myFile.ReadToEnd();
            //myFile.Close();

            List<Block> blocks = Splitter.SplitIntoBlocks(text);
            int[] move = Splitter.GetMove(text);
            MoveHandler.ApplyMove(blocks, move);
            int[] grid = Splitter.GetGrid(text);

            List<Block> interceptingBlocks = TestAllBlocks.CheckForMatches(blocks, grid[0], grid[1]);

            if (interceptingBlocks.Count == 0) Console.WriteLine("false");
            else Console.WriteLine("true");
            Console.ReadKey();

            //all combinations algorithm

            //System.IO.File.WriteAllText(@"C:\Users\Berger Elias\Downloads\lvl1.txt", "xd");

        }
    }
}
