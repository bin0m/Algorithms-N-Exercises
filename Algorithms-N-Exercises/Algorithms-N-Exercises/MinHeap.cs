using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_N_Exercises
{
    public class MinHeap
    {
        private List<int> _baseHeap;

        public bool IsEmpty
        {
            get { return _baseHeap.Count == 0; }
        }

        public MinHeap()
        {
            _baseHeap = new List<int>();
        }

        public MinHeap(int count)
        {
            _baseHeap = new List<int>(count);
        }

        public void Insert(int val)
        {
            _baseHeap.Add(val);
            // heapify after insert, from end to beginning
            HeapifyFromEndToBeginning(_baseHeap.Count - 1);
        }

        public int ExtractMin()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("ExtractMin is failed. MinHeap is empty.");
            }

            int min = _baseHeap[0];
            _baseHeap[0] = _baseHeap[_baseHeap.Count - 1];
            _baseHeap.RemoveAt(_baseHeap.Count - 1);

            // heapify after remove, from  beginning to end
            HeapifyFromBeginningToEnd(0);

            return min;
        }



        private int HeapifyFromEndToBeginning(int pos)
        {
            if (pos >= _baseHeap.Count)
            {
                return -1;
            }

            // heap[i] have children heap[2*i + 1] and heap[2*i + 2] and parent heap[(i-1)/ 2];
            while (pos > 0)
            {
                int parentPos = (pos - 1) / 2;
                if (_baseHeap[parentPos] > _baseHeap[pos])
                {
                    ExchangeElements(parentPos, pos);
                    pos = parentPos;
                }
                else break;
            }
            return pos;
        }

        private void ExchangeElements(int pos1, int pos2)
        {
            int temp = _baseHeap[pos1];
            _baseHeap[pos1] = _baseHeap[pos2];
            _baseHeap[pos2] = temp;
        }

        private int HeapifyFromBeginningToEnd(int pos)
        {
            if (pos >= _baseHeap.Count)
            {
                return -1;
            }

            // heap[i] have children heap[2*i + 1] and heap[2*i + 2] and parent heap[(i-1)/ 2];
            while (true)
            {
                // on each iteration exchange element with its smallest child
                int smallest = pos;
                int leftChildPos = 2 * pos + 1;
                int rightChildPos = 2 * pos + 2;

                if(leftChildPos < _baseHeap.Count
                    && _baseHeap[leftChildPos] < _baseHeap[pos])
                {
                    smallest = leftChildPos;
                }
                if (rightChildPos < _baseHeap.Count
                    && _baseHeap[rightChildPos] < _baseHeap[pos])
                {
                    smallest = rightChildPos;
                }
                if (smallest != pos)
                {
                    ExchangeElements(pos, smallest);
                    pos = smallest;
                }
                else break;


            }
            return pos;
        }
    }
}
