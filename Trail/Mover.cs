using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trail
{
    public static class Mover
    {

        public static int calcMoveLength(List<Move> moves)
        {
            int moveLength = 0;
            int Fcount = 0;

            foreach(Move move in moves)
            {
                Fcount = move.S.Count(x => x == 'F');
                moveLength += move.T * Fcount;
                Fcount = 0;
            }

            return moveLength;
        }

        public static int calcArea(List<Move> moves)
        {
            int maxX = 0;
            int minX = 0;
            int maxY = 0;
            int minY = 0;
            int currentX = 0;
            int currentY = 0;

            int direction = 1;

            foreach (Move move in moves)
            {
                for(int i = 0; i < move.T; i++)
                {
                    foreach (char c in move.S)
                    {
                        if (c == 'R')
                        {
                            if (direction == 4)
                            {
                                direction = 1;
                            }
                            else
                            {
                                direction++;
                            }
                        }
                        else if (c == 'L')
                        {
                            if (direction == 1)
                            {
                                direction = 4;
                            }
                            else
                            {
                                direction--;
                            }
                        }
                        else if (c == 'F')
                        {
                            if (direction == 1)
                            {
                                currentY++;
                                if (currentY > maxY) maxY++;
                            }
                            else if (direction == 2)
                            {
                                currentX++;
                                if (currentX > maxX) maxX++;
                            }
                            else if (direction == 3)
                            {
                                currentY--;
                                if (currentY < minY) minY--;
                            }
                            else if (direction == 4)
                            {
                                currentX--;
                                if (currentX < minX) minX--;
                            }
                        }
                    }
                }
            }              

            return (maxX-minX) * (maxY-minY);
        }

        public static int calcPolygonArea(List<Move> moves)
        {

            List<Point> points = new List<Point>();
            points.Add(new Point(0, 0));

            int currentX = 0;
            int currentY = 0;

            int direction = 1;

            foreach (Move move in moves)
            {
                for (int i = 0; i < move.T; i++)
                {
                    foreach (char c in move.S)
                    {
                        if (c == 'R')
                        {
                            if (direction == 4)
                            {
                                direction = 1;
                            }
                            else
                            {
                                direction++;
                            }
                        }
                        else if (c == 'L')
                        {
                            if (direction == 1)
                            {
                                direction = 4;
                            }
                            else
                            {
                                direction--;
                            }
                        }
                        else if (c == 'F')
                        {
                            if (direction == 1)
                            {
                                currentY++;
                            }
                            else if (direction == 2)
                            {
                                currentX++;
                            }
                            else if (direction == 3)
                            {
                                currentY--;
                            }
                            else if (direction == 4)
                            {
                                currentX--;
                            }
                        }



                        points.Add(new Point(currentX, currentY));
                    }
                }
            }

            points.Add(points[0]);

            return Math.Abs(points.Take(points.Count - 1)
                .Select((p, i) => (points[i + 1].X - p.X) * (points[i + 1].Y + p.Y))
                .Sum() / 2);
        }


        public static int calcPocketArea(List<Move> moves)
        {
            List<Point> points = new List<Point>();
            points.Add(new Point(0, 0));

            int maxX = 0;
            int minX = 0;
            int maxY = 0;
            int minY = 0;
            int currentX = 0;
            int currentY = 0;

            int direction = 1;

            foreach (Move move in moves)
            {
                for (int i = 0; i < move.T; i++)
                {
                    foreach (char c in move.S)
                    {
                        if (c == 'R')
                        {
                            if (direction == 4)
                            {
                                direction = 1;
                            }
                            else
                            {
                                direction++;
                            }
                        }
                        else if (c == 'L')
                        {
                            if (direction == 1)
                            {
                                direction = 4;
                            }
                            else
                            {
                                direction--;
                            }
                        }
                        else if (c == 'F')
                        {
                            if (direction == 1)
                            {
                                currentY++;
                                if (currentY > maxY) maxY++;
                            }
                            else if (direction == 2)
                            {
                                currentX++;
                                if (currentX > maxX) maxX++;
                            }
                            else if (direction == 3)
                            {
                                currentY--;
                                if (currentY < minY) minY--;
                            }
                            else if (direction == 4)
                            {
                                currentX--;
                                if (currentX < minX) minX--;
                            }
                        }



                        points.Add(new Point(currentX, currentY));
                    }
                }
            }

            points.Add(points[0]);

            List<Point> allPointsInArea = new List<Point>();
            List<Point> pointsOutsideOfPolygon = new List<Point>();


            for(int x = minX; x <= maxX; x++)
            {
                for(int y = minY; y <= maxY; y++)
                {
                    allPointsInArea.Add(new Point(x, y));
                }
            }

            foreach(Point p in allPointsInArea)
            {
                int i, j;
                bool even = false;

                for (i = 0, j = points.Count - 1; i < points.Count; j = i++)
                {
                    if (((points[i].Y > p.Y) != (points[j].Y > p.Y)) &&
                     (p.X < (points[j].X - points[i].X) * (p.Y - points[i].Y) / (points[j].Y - points[i].Y) + points[i].X))
                        even = !even;
                }

                if (!even)
                    pointsOutsideOfPolygon.Add(p);
            }
            
            foreach(Point p in pointsOutsideOfPolygon)
            {
                for(int x)
            }


        }



    }
}
