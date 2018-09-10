﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

namespace Algorithms_N_Exercises
{   
    public class Trees
    {
        public class TreeNode
        {
            public int Val;
            public TreeNode Left;
            public TreeNode Right;
            public TreeNode(int x) { Val = x; }
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
                    current.Left = new TreeNode(arr[i].Value);
                    queue.Enqueue(current.Left);
                }

                if (i + 1 < arr.Length)
                {
                    if (arr[i + 1] != null)
                    {
                        current.Right = new TreeNode(arr[i + 1].Value);
                        queue.Enqueue(current.Right);
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
                    sb.Append(node.Val).Append(',');
                    queue.Enqueue(node.Left);
                    queue.Enqueue(node.Right);
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
                if(node.Right != null)
                {
                    queue2.Enqueue(node.Left);
                }
                if (node.Left != null)
                {
                    queue2.Enqueue(node.Right);
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

        // private global variable for all recursion calls
        private static bool _isBalanced;

        // Check if binary tree is Balanced
        // Balanced tree - is defined to be a tree such that the heights of the two subtrees of any node never differ by more that one.
        // O(n)
        public static bool CheckBalanced(TreeNode root)
        {
            _isBalanced = true;
            GetDepthAndCheckBalanced(root);
            return _isBalanced;
        }

        // helper method for CheckBalanced()
        private static int GetDepthAndCheckBalanced(TreeNode root)
        {
            if(!_isBalanced)
            {
                //return error value, when it is already known that tree is not balanced
                return int.MinValue;
            }
            
            if(root == null)
            {
                return -1;
            }

            int leftDepth = GetDepthAndCheckBalanced(root.Left);
            int rightDepth = GetDepthAndCheckBalanced(root.Right);
            if(Math.Abs(leftDepth - rightDepth) > 1)
            {
                _isBalanced = false;
                return int.MinValue;
            }

            return 1 + Math.Max(leftDepth, rightDepth);
        }

    }
}
