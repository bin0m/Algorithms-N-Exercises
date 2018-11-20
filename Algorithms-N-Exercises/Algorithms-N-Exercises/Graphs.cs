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

    }
}
