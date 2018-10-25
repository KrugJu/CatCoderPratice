﻿using System;
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
            //text = myFile.ReadToEnd();
            //myFile.Close();

            string[] inputs = new string[]{
                "6 5 3 0 h 2 3 3 1 h 2 5 5 2 v 6 2 2 0 2",
                "6 5 3 0 h 2 3 3 1 h 2 5 5 2 v 6 2 2 0 1",
                "6 5 3 0 h 2 3 3 1 h 2 5 5 2 v 6 2 2 0 -1",
                "6 5 3 0 h 2 3 3 1 h 2 5 5 2 v 6 2 2 0 -2",
                "6 6 12 0 h 3 4 2 1 v 1 4 3 2 h 1 3 2 3 v 2 1 2 4 v 4 5 2 5 h 3 3 2 6 h 3 2 2 7 h 4 1 2 8 h 5 6 2 9 v 5 3 3 10 v 6 3 3 11 h 5 2 2 0 1",
                "6 6 12 0 h 3 4 2 1 v 1 4 3 2 h 1 3 2 3 v 2 1 2 4 v 4 5 2 5 h 3 3 2 6 h 3 2 2 7 h 4 1 2 8 h 5 6 2 9 v 5 3 3 10 v 6 3 3 11 h 5 2 2 0 -1",
                "6 6 12 0 h 3 4 2 1 h 2 3 2 2 h 1 1 3 3 h 1 2 3 4 v 1 3 2 5 v 1 5 2 6 v 3 5 2 7 h 4 6 3 8 v 4 1 2 9 h 4 3 2 10 v 5 4 2 11 v 6 4 2 5 -1",
                "6 6 10 0 h 3 4 2 1 h 5 2 2 2 v 1 5 2 3 h 3 5 3 4 v 4 2 2 5 h 5 6 2 6 v 2 4 3 7 v 6 3 3 8 h 1 3 2 9 h 1 1 2 5 -1",
                "7 5 6 0 h 1 2 2 1 v 3 1 4 2 h 2 5 3 3 h 6 4 2 4 h 4 3 3 5 v 7 1 3 4 2"
            };

            List<bool> outputs = SolutionFinder.FindAllSolutions(inputs);
            
            foreach(bool output in outputs)
            {
                Console.WriteLine(output);
            }

            
            Console.ReadKey();

            //System.IO.File.WriteAllText(@"C:\Users\Berger Elias\Downloads\lvl1.txt", "xd");

        }
    }
}
