using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berger
{
    class Program
    {
        static void Main(string[] args)
        {
            int clines;
            int ccols;
            int startl;
            int startc;
            List<List<Color>> colors = new List<List<Color>>();
            List<List<int>> distances = new List<List<int>>();
            List<List<string>> sdist = new List<List<string>>();
            List<string> result = new List<string>();
            List <int[]> visited = new List<int[]>();

            using (StreamReader sr = new StreamReader(@"C:\CCC\level2_4.in"))
            {
                string line = sr.ReadLine().Trim();
                clines = Convert.ToInt32(line.Split(' ')[0]);
                ccols = Convert.ToInt32(line.Split(' ')[1]);
                line = sr.ReadLine().Trim();
                startl = Convert.ToInt32(line.Split(' ')[0]);
                startc = Convert.ToInt32(line.Split(' ')[1]);

                for (int i = 0; i < clines; i++)
                {
                    List<Color> cList = new List<Color>();
                    line = sr.ReadLine().Trim();
                    string[] c = line.Split(' ');
                    for(int j = 0; j < c.Length; j+=3)
                    {
                        cList.Add(new Color(Convert.ToInt32(c[j]), Convert.ToInt32(c[j + 1]), Convert.ToInt32(c[j + 2])));
                    }
                    colors.Add(cList);
                }
            }

            int row = startl;
            int col = startc;
            while (row < colors.Count && col < colors[0].Count)
            {
                int right = -1;
                int up = -1;
                int down = -1;
                if (col < colors[0].Count - 1)
                    right = colors[row][col].getDistance(colors[row][col + 1]);
                if(row > 0)
                    up = colors[row][col].getDistance(colors[row - 1][col]);
                if(row < colors.Count - 1)
                    down = colors[row][col].getDistance(colors[row + 1][col]);

                
            }

            foreach (List<Color> cline in colors)
            {
                List<int> distLine = new List<int>();
                List<string> sdistLine = new List<string>();
                for (int i = 0; i < ccols - 1; i++)
                {
                    distLine.Add(cline[i].getDistance(cline[i+1]));
                    sdistLine.Add(cline[i].getDistance(cline[i+1]).ToString());
                }
                distances.Add(distLine);
                sdist.Add(sdistLine);
            }

            foreach(List<string> l in sdist)
            {
                result.Add(String.Join(" ", l));
            }
            System.IO.File.WriteAllLines(@"C:\CCC\level2_4.ou", result);
        }
    }
}
