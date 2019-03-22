﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GeneticDrift
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp = "193 125 133 134 135 136 -52 -51 -50 -49 -48 -47 -46 -45 66 67 68 69 70 71 -38 -37 -36 -35 -34 -33 -32 -31 -30 -29 -132 -131 -130 -193 -192 -191 -190 -189 -188 -187 -186 -185 -184 -183 -182 -181 -180 -179 -178 -177 -176 -175 -174 -173 -172 -171 -170 -169 -77 -76 -75 -74 -73 -72 18 19 20 21 22 23 24 25 26 27 28 -164 -163 -65 -64 -63 -62 -61 -60 -59 -58 -57 -56 -55 -54 -53 39 40 41 42 43 44 159 160 161 162 -17 -16 -15 -14 -13 -12 -11 -10 -9 -8 -7 -6 -5 -4 -3 -2 -1 -168 -167 -166 -165 126 127 128 129 86 87 88 89 90 91 92 93 94 95 96 -124 -123 -122 -121 -120 -119 -118 -117 -116 -115 -114 -113 -112 -111 -110 -109 -108 -107 -106 -105 -104 -103 -102 -101 -100 -99 -98 -97 153 154 155 156 157 158 -148 -147 -146 -145 -144 -143 -142 -141 -140 -139 -138 -137 -85 -84 -83 -82 -81 -80 -79 -78 -152 -151 -150 -149 -45 12 44 94";
            //string[] input = Console.ReadLine().Trim().Split(' ');
            string[] input = inp.Trim().Split(' ');
            List<int[]> Pairs = new List<int[]>();
            string result = "";

            for(int i = 1; i <= Convert.ToInt32(input[0]); i++)
            {
                for(int j = i + 1; j <= Convert.ToInt32(input[0]); j++)
                {
                    int I = Convert.ToInt32(input[i]);
                    int J = Convert.ToInt32(input[j]);
                    if((I < 0 && J >= 0 || I >= 0 && J < 0) && (Math.Abs(I) == Math.Abs(J) - 1 ||
                        Math.Abs(I) == Math.Abs(J) + 1))
                    {
                        Pairs.Add(new int[2] {I, J});
                    }
                }
            }

            List<int> P = input.Select(int.Parse).ToList();
            P.RemoveAt(0);
            P.RemoveRange(P.Count - 4, 4);

            int xi = Convert.ToInt32(input[input.Length - 4]);
            int ii = Convert.ToInt32(input[input.Length - 3]);
            int yi = Convert.ToInt32(input[input.Length - 2]);
            int ij = Convert.ToInt32(input[input.Length - 1]);

            if(xi + yi == 1)
            {
                P.Reverse(ii, ij - ii);
                for(int i = ii; i <= ij - 1; i++)
                {
                    P[i] = -P[i];
                }
            }
            else if(xi + yi == -1)
            {
                P.Reverse(ii + 1, ij - ii);
                for (int i = ii + 1; i <= ij; i++)
                {
                    P[i] = -P[i];
                }
            }

            Pairs = Pairs.OrderBy(a => a[0]).ToList();
            //result += $"{Pairs.Count} ";
            //foreach(int[] pair in Pairs)
            //{
            //    result += $"{pair[0]} {pair[1]} ";
            //}

            foreach(int x in P)
            {
                result += $"{x} ";
            }



            


            Console.WriteLine(result.Trim());
            Console.ReadKey();
        }
    }
}
