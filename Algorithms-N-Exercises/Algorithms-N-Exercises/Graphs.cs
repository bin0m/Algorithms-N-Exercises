using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_N_Exercises
{
    public static class Graphs
    {
        private class CityAreas
        {
            private readonly List<HashSet<int>> areas = new List<HashSet<int>>();

            public int AreaCount { get; private set; }

            // return number of new cities that were added
            public int AddConnectedCities(int city1, int city2)
            {
                int numOfAdded = 0;
                int area1 = GetAreaNum(city1);
                int area2 = GetAreaNum(city2);
                if (area1 == -1 && area2 == -1)
                {
                    var newArea = new HashSet<int>() { city1, city2 };
                    areas.Add(newArea);
                    AreaCount++;
                    numOfAdded = 2;
                }
                else if (area1 >= 0 && area2 == -1)
                {
                    areas[area1].Add(city2);
                    numOfAdded = 1;
                }
                else if (area1 == -1 && area2 >= 0)
                {
                    areas[area2].Add(city1);
                    numOfAdded = 1;
                }
                else if (area1 != area2)
                {
                    //union areas
                    areas[area1].UnionWith(areas[area2]);
                    areas.RemoveAt(area2);
                    AreaCount--;
                }

                return numOfAdded;
            }

            public int GetAreaNum(int city)
            {
                for (int i = 0; i < AreaCount; i++)
                {
                    if (areas[i].Contains(city))
                    {
                        return i;
                    }
                }
                return -1;
            }
        }

        // find the minimum cost of making libraries accessible to all the citizens and print it on a new line.
        static long RoadsAndLibraries(int n, int c_lib, int c_road, int[][] cities)
        {
            if (c_road >= c_lib)
            {
                return c_lib * n;
            }
            // n = 3
            // c_lib = 2
            // c_road = 1
            // cityArea = { 1 1 0 }
            // areaCounter = 1

            // divide cities to connected areas
            var cityAreas = new CityAreas();
            int unconnectedCitites = n;
            foreach (var cityPair in cities)
            {
                int addedNum = cityAreas.AddConnectedCities(cityPair[0], cityPair[1]);
                unconnectedCitites = unconnectedCitites - addedNum;
            }

            return c_lib * (cityAreas.AreaCount + unconnectedCitites) + c_road * (n - cityAreas.AreaCount - unconnectedCitites);
            
        }


        // time: O(n*m)
        // space: O(n*m)
        public static int GetNumberOfIslands(int[,] binaryMatrix)
        {
            // edge cases 
            if (binaryMatrix == null)
            {
                return 0;
            }
            int n = binaryMatrix.GetLength(0);       // number of rows
            int m = binaryMatrix.GetLength(1);       // number of columns
            if (n == 0 || m == 0)
            {
                return 0;
            }

            bool[,] colorMatrix = new bool[n, m];
            int islandsCount = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (binaryMatrix[i, j] == 1 && colorMatrix[i, j] == false)
                    {

                        islandsCount++;
                        MarkIsland(binaryMatrix, colorMatrix, i, j);
                    }
                }
            }

            return islandsCount;
        }

        // helper for GetNumberOfIslands
        // time: O(n*m)
        // recursively marks single Island
        private static void MarkIsland(int[,] binaryMatrix, bool[,] colorMatrix, int i, int j)
        {

            int n = binaryMatrix.GetLength(0);       // number of rows
            int m = binaryMatrix.GetLength(1);       // number of columns
            //return if out of bounds or already marked
            if (!(i >= 0 && i < n && j >= 0 && j < m && binaryMatrix[i, j] == 1 && colorMatrix[i, j] == false))
            {
                return;
            }
            //Console.WriteLine("recursive i="+i+",j="+j);
            //mark
            colorMatrix[i, j] = true;

            // right
            MarkIsland(binaryMatrix, colorMatrix, i, j + 1);
            // down
            MarkIsland(binaryMatrix, colorMatrix, i + 1, j);
            // up
            MarkIsland(binaryMatrix, colorMatrix, i - 1, j);
            // left
            MarkIsland(binaryMatrix, colorMatrix, i, j - 1);
        }


    }
}
