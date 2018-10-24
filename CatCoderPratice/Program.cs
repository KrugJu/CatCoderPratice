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
            System.IO.StreamReader myFile = new System.IO.StreamReader("C:\\Users\\Berger Elias\\Downloads\\lvl1.inp");
            string text;
            text = myFile.ReadToEnd();
            myFile.Close();

            List<Block> blocks = Splitter.Split(text);
            List<Block> interceptingBlocks = TestAllBlocks.CheckForMatches(blocks);

            if (interceptingBlocks == null) Console.WriteLine("false");
            else Console.WriteLine("true");

            //all combinations algorithm

            System.IO.File.WriteAllText(@"C:\Users\Berger Elias\Downloads\lvl1.txt", "xd");

        }
    }
}
