using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_N_Exercises
{
    public class QueueViaStacks<T> 
    {
        private readonly Stack<T> inStack;
        private readonly Stack<T> outStack;

        public QueueViaStacks()
        {
            inStack = new Stack<T>();
            outStack = new Stack<T>();
        }

        public void Enqueue(T item)
        {
            inStack.Push(item);
        }

        public T Dequeue()
        {
            if(outStack.Count > 0)
            {
                return outStack.Pop();
            }
            else if (inStack.Count > 0)
            {
                ShiftStacks();
                return outStack.Pop();
            }
            else
            {
                throw new InvalidOperationException("Queue is empty");
            }
        }

        public T Peek()
        {
            if(outStack.Count == 0 && inStack.Count > 0)
            {
                ShiftStacks();
            }

            if (outStack.Count > 0)
            {
                return outStack.Peek();
            }
            else
            {
                throw new InvalidOperationException("Queue is Empty");
            }
        }

        private void ShiftStacks()
        {
            while (inStack.Count > 0)
            {
                outStack.Push(inStack.Pop());
            }
        }
    }
}
