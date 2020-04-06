using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class MinHeap
    {
        private int Capacity = 10;
        int size = 0;
        int[] items;
        public MinHeap()
        {
            items = new int[10];
        }
        public int getleftChildindex(int index) { return (2 * index) + 1; }
        public int getrightChildindex(int index) { return (2 * index) + 2; }
        public int getParentindex(int index) { return (index - 1) / 2; }

        private bool hasleftChild(int index) { return getleftChildindex(index) < size; }
        private bool hasRightChild(int index) { return getrightChildindex(index) < size; }
        private bool hasParent(int index) { return getParentindex(index) >= 0; }

        private int leftChild(int index) { return items[getleftChildindex(index)]; }
        private int RightChild(int index) { return items[getrightChildindex(index)]; }
        private int Parent(int index) { return items[getParentindex(index)]; }

        private void swap(int indexOne,int indexTwo)
        {
            int temp = items[indexOne];
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
        public int Peek()
        {
            if (size == 0) throw new Exception();
            return items[0];
        }
        public int poll()
        {
            if (size == 0) throw new Exception();
            int item = items[0];
            items[0] = items[size - 1];
            size--;
            heapifydown();
            return item;
        }
        public void add(int item)
        {
            ensureExtraCapacity();
            items[size] = item;
            size++;
            heapifyup();
        }
        private void heapifydown()
        {
            int index = 0;
            while(hasleftChild(index))
            {
                int childIndex = getleftChildindex(index);
                if(hasRightChild(index)&&items[getrightChildindex(index)]<items[childIndex])
                {
                    childIndex = getrightChildindex(index);
                }
                if (items[childIndex] > items[index])
                    break;
                swap(childIndex, index);
                index = childIndex;
            }
        }
        private void heapifyup()
        {
            int index = size - 1;
            while(hasParent(index)&&Parent(index)>items[index])
            {
                int ParentIndex = getParentindex(index);
                swap(index, ParentIndex);
                index = ParentIndex;
            }
        }
    }
}
