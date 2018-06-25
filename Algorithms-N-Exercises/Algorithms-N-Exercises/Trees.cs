﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_N_Exercises
{
    public class Trees
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        // helper method
        internal static TreeNode CreateBinaryTree(int?[] arr)
        {
            if (arr == null || arr.Length < 1)
            {
                return null;
            }

            TreeNode root = new TreeNode(arr[0].Value);
            //int levels = (int)Math.Log(arr.Length, 2);
            Queue<TreeNode> queue = new Queue<TreeNode>(arr.Length);
            queue.Enqueue(root);
            for (int i = 1; i < arr.Length; i++)
            {
                TreeNode current = queue.Dequeue();
                if (arr[i] != null)
                {
                    current.left = new TreeNode(arr[i].Value);
                    queue.Enqueue(current.left);
                }

                if (i + 1 < arr.Length)
                {
                    if (arr[i + 1] != null)
                    {
                        current.right = new TreeNode(arr[i + 1].Value);
                        queue.Enqueue(current.right);
                    }

                    i++;
                }
            }

            return root;
        }

        // helper method for printing Tree
        internal static String TreeNodeToString(TreeNode root)
        {
            var sb = new StringBuilder();
            sb.Append('[');

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                if (node != null)
                {
                    sb.Append(node.val).Append(',');
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
                else
                {
                    sb.Append("null,");
                }
            }
            sb.Append(']');
            return sb.ToString();
        }

        // List Of Depths of binary Tree
        // O(n)
        public static List<LinkedList<TreeNode>> ListOfDepths(TreeNode root)
        {
            var lists = new List<LinkedList<TreeNode>>();
            var queue1 = new Queue<TreeNode>();
            var queue2 = new Queue<TreeNode>();
            queue1.Enqueue(root);
            var currentList = new LinkedList<TreeNode>();
            while(queue1.Count > 0)
            {
                TreeNode node = queue1.Dequeue();
                currentList.AddLast(node);
                if(node.right != null)
                {
                    queue2.Enqueue(node.left);
                }
                if (node.left != null)
                {
                    queue2.Enqueue(node.right);
                }
                if(queue1.Count == 0)
                {
                    queue1 = queue2;
                    queue2 = new Queue<TreeNode>();
                    lists.Add(currentList);
                    currentList = new LinkedList<TreeNode>();
                }
            }
            return lists;
        }
    }
}
