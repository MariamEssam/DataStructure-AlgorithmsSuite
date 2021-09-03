using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class MinHeap<T>
    {
        IComparer<T> compare;
        private int Capacity = 10;
        //occupied capacity
        public long size = 0;
        T[] items;
        public MinHeap(IComparer<T> comp)
        {
            compare = comp;
            items = new T[10];
        }
        public long getleftChildindex(long parentIndex) { return (2 * parentIndex) + 1; }
        public long getrightChildindex(long parentIndex) { return (2 * parentIndex) + 2; }
        public long getParentindex(long childIndex) { return (childIndex - 1) / 2; }

        private bool hasleftChild(long index) { return getleftChildindex(index) < size; }
        private bool hasRightChild(long index) { return getrightChildindex(index) < size; }
        private bool hasParent(long index) { return getParentindex(index) >= 0; }

        private T leftChild(long index) { return items[getleftChildindex(index)]; }
        private T RightChild(long index) { return items[getrightChildindex(index)]; }
        private T Parent(long index) { return items[getParentindex(index)]; }

        private void swap(long indexOne,long indexTwo)
        {
            T temp = items[indexOne];
            items[indexOne] = items[indexTwo];
            items[indexTwo] = temp;
        }
        private void ensureExtraCapacity()
        {
            if(size==Capacity)
            {
                Array.Resize(ref items, 2 * Capacity);
                Capacity *= 2;
            }
        }
        public T Peek()
        {
            if (size == 0) throw new Exception();
            return items[0];
        }
        public T poll()
        {
            if (size == 0) throw new Exception();
            T item = items[0];
            items[0] = items[size - 1];
            size--;
            heapifydown();
            return item;
        }
        public void add(T item)
        {
            ensureExtraCapacity();
            items[size] = item;
            size++;
            heapifyup();
        }
        private void heapifydown()
        {
            long index = 0;
            while(hasleftChild(index))
            {
                long childIndex = getleftChildindex(index);
                if(hasRightChild(index)&&compare.Compare(items[getrightChildindex(index)],items[childIndex])==-1)
                {
                    childIndex = getrightChildindex(index);
                }
                if (compare.Compare(items[childIndex] , items[index])==1)
                    break;
                swap(childIndex, index);
                index = childIndex;
            }
        }
        private void heapifyup()
        {
            long index = size - 1;
            while(hasParent(index)&&compare.Compare(Parent(index),items[index])==1)
            {
                long ParentIndex = getParentindex(index);
                swap(index, ParentIndex);
                index = ParentIndex;
            }
        }
    }
}
