﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCoderPratice
{
    public static class TestAllBlocks
    {
        public static List<Block> CheckForMatches(List<Block> _blocks, int gridx, int gridy)
        {
            List<Block> matches = new List<Block>();
            for (int i = 0; i < _blocks.Count; i++)
            {
                for (int i1 = 0; i1 < _blocks.Count; i1++)
                {
                    if (!_blocks[i].Equals(_blocks[i1]))
                    {
                        if (Checker.CheckForInterception(_blocks[i], _blocks[i1], gridx, gridy))
                        {
                            matches.Add(_blocks[i]);
                            matches.Add(_blocks[i1]);
                        }
                    }
                }
            }
            return matches;
            
        }
    }
}
