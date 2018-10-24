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
            string text = "0 h 2 3 5 1 v 4 1 5";
            //text = myFile.ReadToEnd();
            //myFile.Close();

            List<Block> blocks = Splitter.Split(text);
            List<Block> interceptingBlocks = TestAllBlocks.CheckForMatches(blocks);

            if (interceptingBlocks.Count == 0) Console.WriteLine("false");
            else Console.WriteLine("true");


            //System.IO.File.WriteAllText(@"C:\Users\Berger Elias\Downloads\lvl1.txt", "xd");

        }
    }
}
