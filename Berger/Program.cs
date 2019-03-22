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
            List<List<Color>> colors = new List<List<Color>>();
            List<int> distances = new List<int>();
            List<string> sdist = new List<string>();

            using (StreamReader sr = new StreamReader(@"C:\CCC\level1_3.in"))
            {
                string line;
                clines = Convert.ToInt32(sr.ReadLine().Trim());

                for(int i = 0; i < clines; i++)
                {
                    List<Color> cList = new List<Color>();
                    line = sr.ReadLine().Trim();
                    string[] c = line.Split(' ');
                    cList.Add(new Color(Convert.ToInt32(c[0]), Convert.ToInt32(c[1]), Convert.ToInt32(c[2])));
                    cList.Add(new Color(Convert.ToInt32(c[3]), Convert.ToInt32(c[4]), Convert.ToInt32(c[5])));
                    colors.Add(cList);
                }
            }

            foreach (List<Color> pair in colors)
            {
                distances.Add(pair[0].getDistance(pair[1]));
                sdist.Add(pair[0].getDistance(pair[1]).ToString());
            }


            System.IO.File.WriteAllLines(@"C:\CCC\level1_3.ou", sdist);

        }
    }
}
