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
            string text = "0 h 2 3 3 2 v 6 2 2";
            //text = myFile.ReadToEnd();
            //myFile.Close();

            List<Block> blocks = Splitter.Split(text);
            List<Block> interceptingBlocks = TestAllBlocks.CheckForMatches(blocks);

            if (interceptingBlocks.Count == 0) Console.WriteLine("false");
            else Console.WriteLine("true");

            //all combinations algorithm

            //System.IO.File.WriteAllText(@"C:\Users\Berger Elias\Downloads\lvl1.txt", "xd");

        }
    }
}
