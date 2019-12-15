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

        static int CurrentNthToLast = 0;

        public ListNode<int> NthToLast(ListNode<int> head, int n)
        {
            if(head == null)
            {
                return null;
            }

            ListNode<int> node = NthToLast(head.Next, n);

            if (CurrentNthToLast == n)
            {
                return head;
            }

            CurrentNthToLast++;            

            return node;

        }

        // Input: 1->2->3->4->5->NULL
        // Output: 5->4->3->2->1->NULL
        public ListNode<int> ReverseListRecursive(ListNode<int> head)
        {
            return ReverseNode(null, head);
        }

        // -> 1 -> NULL
        // next -> NULL

        private ListNode<int> ReverseNode(ListNode<int> prev, ListNode<int> curr)
        {
            if (curr == null)
            {
                return prev;
            }

            var next = curr.Next;
            curr.Next = prev;
            return ReverseNode(curr, next);
        }

        // Input: 1->2->3->4->5->NULL
        // Output: 5->4->3->2->1->NULL
        public ListNode<int> ReverseListIterative(ListNode<int> head)
        {
            ListNode<int> prev = null;
            ListNode<int> curr = head;
            while (curr != null)
            {
                var next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }
            return prev;
        }



    }
}
