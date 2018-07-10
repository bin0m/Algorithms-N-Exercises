using System;

namespace Algorithms_N_Exercises
{
    public class LinkedLists
    {
        public class ListNode<T>
        {
            public ListNode<T> Next;
            public T Val;
            public ListNode(T val)
            {
                this.Val = val;
            }
        }

        static int _currentNthToLast = 0;

        public ListNode<int> NthToLast(ListNode<int> head, int n)
        {
            if(head == null)
            {
                return null;
            }

            ListNode<int> node = NthToLast(head.Next, n);

            if (_currentNthToLast == n)
            {
                return head;
            }

            _currentNthToLast++;            

            return node;

        }


    }
}
