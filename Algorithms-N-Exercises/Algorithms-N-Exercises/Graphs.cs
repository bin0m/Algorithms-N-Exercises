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

        // Given undirected graph where each edge is the same weight.
        // n: the integer number of nodes
        // m: the integer number of edges
        // edges: a 2D array of start and end nodes for edges
        // s: the node to start traversals from
        // Returns: Shortest distance to each of the other nodes from a given starting position using the (BFS).
        //          Distances are to be reported in node number order, ascending. 
        //          If a node is unreachable, return -1 for that node. Each of the edges weighs 6 units of distance.
        public static int[] GetShortestDistances(int n, int m, int[][] edges, int s)
        {
            const int EDGE_DISTANCE = 6;

            // helper lookup of neighboors for every vertex
            List<int>[] neighbours = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                neighbours[i] = new List<int>();
            }

            // decrease number of node, because we start from 0, not from 1
            s--;

            // fill lookup of neighboors for every vertex
            for (int i = 0; i < m; i++)
            {
                int v1 = edges[i][0] - 1;
                int v2 = edges[i][1] - 1;
                neighbours[v1].Add(v2);
                neighbours[v2].Add(v1);
            }

            bool[] visited = new bool[n];
            int[] dist = new int[n];

            // init dist values to -1 default
            for (int i = 0; i < n; i++)
            {
                dist[i] = -1;
            }

            // debug info
            // n=3 
            // m=1
            // edges = [[2 3]]
            // neighboors = [ {} {2} {1} ]
            // s = 1
            // queue = {}
            // dist =  [-1  0 -1 ]
            // visited [ 0  1  1 ]
            // curr = 1
            // w = 2
            
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(s);
            dist[s] = 0;
            visited[s] = true;

            while (queue.Count > 0)
            {
                var curr = queue.Dequeue();

                foreach (var w in neighbours[curr])
                {
                    if (!visited[w])
                    {
                        visited[w] = true;
                        dist[w] = dist[curr] + EDGE_DISTANCE;
                        queue.Enqueue(w);
                    }
                }
            }

            int[] distWithoutStart = new int[n - 1];
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == s)
                {
                    continue;
                }
                distWithoutStart[j++] = dist[i];
            }
            return distWithoutStart;
        }

        /*
         * We want to find the longest (as determined by the number of characters) absolute path to a file within our system.
         * For example, in the second example above, the longest absolute path is "user/documents/lectures/notes.txt",
         * and its length is 33 (not including the double quotes).
         */
        public static int longestPath(string fileSystem)
        {
            if (string.IsNullOrEmpty(fileSystem))
            {
                return 0;
            }
            string[] nodes = fileSystem.Split('\f');
            List<int> roots = GetRootsList(nodes);
            int max = 0;
            foreach (int id in roots)
            {
                int ajacencyLength = GetLongestPathDFS(id, nodes);
                max = Math.Max(ajacencyLength, max);
            }
            return max;
        }

        static int GetLongestPathDFS(int nodeId, string[] nodes)
        {
            int length = GetLength(nodes[nodeId]);
            if (IsFile(nodes[nodeId]))
            {
                return length;
            }

            List<int> adjacencyList = GetAdjacencyList(nodeId, nodes);
            int max = 0;
            foreach (int id in adjacencyList)
            {
                int ajacencyLength = GetLongestPathDFS(id, nodes);
                max = Math.Max(ajacencyLength, max);
            }
            if (max > 0)
            {
                max = max + length + 1;
            }
            return max;
        }

        static List<int> GetAdjacencyList(int nodeId, string[] nodes)
        {
            // nodeId = 0
            // nodes = {dir}
            int rootLevel = GetLevel(nodes[nodeId]);
            List<int> list = new List<int>();
            for (int i = nodeId + 1; i < nodes.Length; i++)
            {
                int level = GetLevel(nodes[i]);
                if (level == rootLevel)
                {
                    // i node is on the same level, it means no more children for nodeId
                    break;
                }
                else if (level == rootLevel + 1)
                {
                    list.Add(i);
                }
            }
            return list;
        }

        static List<int> GetRootsList(string[] nodes)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < nodes.Length; i++)
            {
                int level = GetLevel(nodes[i]);
                if (level == 0)
                {
                    list.Add(i);
                }
            }
            return list;
        }

        static bool IsFile(string name)
        {
            return name.Contains('.');
        }

        static int GetLevel(string name)
        {
            int level = 0;
            foreach (char c in name)
            {
                if (c != '\t')
                {
                    break;
                }
                level++;
            }
            return level;
        }

        static int GetLength(string name)
        {
            int length = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] != '\t')
                {
                    length = name.Length - i;
                    break;
                }
            }
            return length;
        }

    }
}
