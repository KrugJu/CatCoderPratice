using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvester
{
    public static class Orderer
    {

        public static List<int> orderCornerMatrix(List<int> values)
        {
            int[,] field = new int[values[0], values[1]];

            List<int> orderedValues = new List<int>();
            int fieldCounter = 1;

            for (int l = 0; l < field.GetLength(0); l++)
            {
                for (int k = 0; k < field.GetLength(1); k++)
                {
                    field[l, k] = fieldCounter;
                    fieldCounter++;
                }
            }

            bool goRight;

            int i = values[2] - 1;
            int j = values[3] - 1;


            if (i != field.GetLength(0) - 1)
            {

                for (; i < field.GetLength(0); i++)
                {
                    
                    if (j == field.GetLength(1) - 1)
                        goRight = false;
                    else
                        goRight = true;

                    if (goRight)
                    {
                        j = 0;
                        while (j < field.GetLength(1))
                        {
                            orderedValues.Add(field[i, j]);
                            j++;
                        }
                    }
                    else
                    {
                        j = field.GetLength(1) - 1;
                        while (j >= 0)
                        {
                            orderedValues.Add(field[i, j]);
                            j--;
                        }
                    }

                    goRight = !goRight;
                }
            }
            else
            {
                for (; i >= 0; i--)
                {
                    
                    if (j == field.GetLength(1) - 1)
                        goRight = false;
                    else
                        goRight = true;

                    if (goRight)
                    {
                        j = 0;
                        while (j < field.GetLength(1))
                        {
                            orderedValues.Add(field[i, j]);
                            j++;
                        }
                    }
                    else
                    {
                        j = field.GetLength(1) - 1;
                        while (j >= 0)
                        {
                            orderedValues.Add(field[i, j]);
                            j--;
                        }
                    }

                    goRight = !goRight;
                }
            }

            

            return orderedValues;

        }

        public static List<int> orderMatrix(List<int> values)
        {
            int[,] field = new int[values[0], values[1]];

            List<int> orderedValues = new List<int>();
            int j = 0;
            int fieldCounter = 1;

            for(int i = 0; i < field.GetLength(0); i++)
            {
                for(int k = 0; k < field.GetLength(1); k++)
                {
                    field[i, k] = fieldCounter;
                    fieldCounter++;
                }
            }




            for (int i = 0; i < field.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    j = 0;
                    while (j < field.GetLength(1))
                    {
                        orderedValues.Add(field[i, j]);
                        j++;   
                    }
                }
                else
                {
                    j = field.GetLength(1) - 1;
                    while (j >= 0)
                    {
                        orderedValues.Add(field[i, j]);
                        j--;
                    }
                }
            }
            return orderedValues;
        }
    }
}
