using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_N_Exercises
{
    public class LinkedLists
    {
        public class ListNode<T>
        {
            public ListNode<T> next;
            public T val;
            public ListNode(T val)
            {
                this.val = val;
            }
        }

        static int currentNthToLast = 0;

        public ListNode<int> NthToLast(ListNode<int> head, int n)
        {
            if(head == null)
            {
                return null;
            }

            ListNode<int> node = NthToLast(head.next, n);

            if (currentNthToLast == n)
            {
                return head;
            }

            currentNthToLast++;            

            return node;

        }


    }
}
