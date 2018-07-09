using System;
using System.Collections.Generic;

namespace Algorithms_N_Exercises
{
    public class QueueViaStacks<T> 
    {
        private readonly Stack<T> _inStack;
        private readonly Stack<T> _outStack;

        public QueueViaStacks()
        {
            _inStack = new Stack<T>();
            _outStack = new Stack<T>();
        }

        public void Enqueue(T item)
        {
            _inStack.Push(item);
        }

        public T Dequeue()
        {
            if(_outStack.Count > 0)
            {
                return _outStack.Pop();
            }
            else if (_inStack.Count > 0)
            {
                ShiftStacks();
                return _outStack.Pop();
            }
            else
            {
                throw new InvalidOperationException("Queue is empty");
            }
        }

        public T Peek()
        {
            if(_outStack.Count == 0 && _inStack.Count > 0)
            {
                ShiftStacks();
            }

            if (_outStack.Count > 0)
            {
                return _outStack.Peek();
            }
            else
            {
                throw new InvalidOperationException("Queue is Empty");
            }
        }

        private void ShiftStacks()
        {
            while (_inStack.Count > 0)
            {
                _outStack.Push(_inStack.Pop());
            }
        }
    }
}
