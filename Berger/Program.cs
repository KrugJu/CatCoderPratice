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
            string path = "";

            using (StreamReader sr = new StreamReader(@"C:\CCC\level3_4.in"))
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

            List<List<bool>> visited = new List<List<bool>>();
            for(int i = 0; i < colors.Count; i++)
            {
                List<bool> v = new List<bool>();
                for(int j = 0; j < colors[0].Count; j++)
                {
                    v.Add(false);
                }
                visited.Add(v);
            }

            int row = startl;
            int col = startc;
            visited[row][col] = true;
            path += $"{row} {col}\n";

            while (row < colors.Count && col < colors[0].Count)
            {
                int up = Int32.MaxValue;
                int right = Int32.MaxValue;
                int down = Int32.MaxValue;

                if (row > 0 && !visited[row - 1][col])
                    up = colors[row][col].getDistance(colors[row - 1][col]);
                if (col < colors[0].Count - 1 && !visited[row][col+1])
                    right = colors[row][col].getDistance(colors[row][col + 1]);
                if(row < colors.Count - 1 && !visited[row + 1][col])
                    down = colors[row][col].getDistance(colors[row + 1][col]);

                if (right == Int32.MaxValue && up == Int32.MaxValue && down == Int32.MaxValue)
                    break;

                if (up <= right && up <= down)
                {
                    row = row - 1;
                    visited[row][col] = true;
                    path += $"{row} {col}\n";
                }
                else if(right <= down)
                {
                    col = col + 1;
                    visited[row][col] = true;
                    path += $"{row} {col}\n";
                }
                else
                {
                    row = row + 1;
                    visited[row][col] = true;
                    path += $"{row} {col}\n";
                }
            }

            System.IO.File.WriteAllText(@"C:\CCC\level3_4.ou", path.Trim());

            //foreach (List<Color> cline in colors)
            //{
            //    List<int> distLine = new List<int>();
            //    List<string> sdistLine = new List<string>();
            //    for (int i = 0; i < ccols - 1; i++)
            //    {
            //        distLine.Add(cline[i].getDistance(cline[i+1]));
            //        sdistLine.Add(cline[i].getDistance(cline[i+1]).ToString());
            //    }
            //    distances.Add(distLine);
            //    sdist.Add(sdistLine);
            //}

            //foreach(List<string> l in sdist)
            //{
            //    result.Add(String.Join(" ", l));
            //}

            //System.IO.File.WriteAllLines(@"C:\CCC\level2_4.ou", result);
        }
    }
}
