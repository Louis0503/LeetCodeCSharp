using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DataStruct
{
    public class MinHeap<T> where T : IComparable
    {
        List<T> elements;
        public MinHeap()
        {
            elements = new List<T>();
        }
        public void Add(T item)
        {
            elements.Add(item);
            Heapify();
        }
        public void Delete(T item)
        {
            int index = elements.IndexOf(item);
            int last = elements.Count - 1;
            elements[index] = elements[last];
            elements.RemoveAt(last);
            Heapify();
        }

        public T PopMin()
        {
            if (elements.Count > 0){
                T item = elements[0];
                Delete(item);
                return item;
            }
            return default(T);
        }


        #region Help Methods
        private void Heapify()
        {
            for (int i = elements.Count - 1; i > 0; i--){
                int parentPosition = (i + 1) / 2 - 1;
                parentPosition = parentPosition >= 0 ? parentPosition : 0;

                if (elements[parentPosition].CompareTo(elements[i]) > 1){
                    SwapElements(parentPosition, i);
                }
            }
        }

        private void SwapElements(int leftIndex, int rightIndex)
        {
            T tmp = elements[leftIndex];
            elements[leftIndex] = elements[rightIndex];
            elements[rightIndex] = tmp;
        }

        #endregion
    }
}
