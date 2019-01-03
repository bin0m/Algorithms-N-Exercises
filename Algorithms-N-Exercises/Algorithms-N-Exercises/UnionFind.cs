   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_N_Exercises
{
    public class UnionFind
    {
        readonly int[] trees;
        readonly int[] ranks;

        public UnionFind(int size)
        {
            trees = new int[size];
            ranks = new int[size];

            for (var i = 0; i < size; ++i)
            {
                trees[i] = i;
            }
        }

        public int Find(int branch)
        {
            var root = branch;

            for (; root != trees[root]; root = trees[root]) ;

            while (branch != root)
            {
                var stem = trees[branch];
                trees[branch] = root;
                branch = stem;
            }

            return root;
        }

        public void Union(int first, int second)
        {
            first = Find(first);
            second = Find(second);

            if (first != second)
            {
                if (ranks[first] < ranks[second])
                {
                    trees[first] = second;
                }
                else
                {
                    trees[second] = first;

                    if (ranks[first] == ranks[second])
                    {
                        ++ranks[first];
                    }
                }
            }
        }       
    }
}
