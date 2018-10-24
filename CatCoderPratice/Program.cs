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
            string[] splitText = text.Split(' ', (char)10);
            System.IO.StreamReader myFile = new System.IO.StreamReader("C:\\Users\\Berger Elias\\Downloads\\lvl1.inp");
            string text;
            text = myFile.ReadToEnd();
            myFile.Close();

            List<Block> blocks = Splitter.Split(text);

            //all combinations algorithm
            System.IO.File.WriteAllText(@"C:\Users\Berger Elias\Downloads\lvl1.txt", "xd");

        }
    }
}
