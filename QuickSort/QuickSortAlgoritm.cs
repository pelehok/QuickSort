using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class QuickSortAlgoritm
    {
        public delegate void AddOne();
        public event AddOne AddOneHandler;
        public int count = 0;
        public int Partition(List<int> inputList, int leftIndex,int rightIndex)
        {
            int p = ChoosePivot(inputList, leftIndex, rightIndex).Value;
            int i = leftIndex + 1;
            for(int j = leftIndex + 1; j <= rightIndex; j++)
            {
                AddOneHandler();
                if (inputList[j] < p)
                {
                    //Swap(inputList, j, i);
                    int temp = inputList[j];
                    inputList[j] = inputList[i];
                    inputList[i] = temp;
                    i++;
                }
            }
            //Swap(inputList, leftIndex, i - 1);

            int temp1 = inputList[leftIndex];
            inputList[leftIndex] = inputList[i-1];
            inputList[i-1] = temp1;
            return i - 1;
        }
        public void QuickSort(List<int> inputList,int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex) return;

            int i = ChoosePivot(inputList, leftIndex, rightIndex).Key;
            Swap(inputList, leftIndex, i);

            int j = Partition(inputList, leftIndex, rightIndex);
            count += (rightIndex - leftIndex);
            QuickSort(inputList, leftIndex, j - 1);
            QuickSort(inputList, j + 1, rightIndex);
        }

        public KeyValuePair<int,int> ChoosePivot(List<int> inputList, int leftIndex,int rightIndex)
        {
            List<KeyValuePair<int, int>> medianeThree = new List<KeyValuePair<int, int>>();
            medianeThree.Add(new KeyValuePair<int, int>(leftIndex, inputList[leftIndex]));

            int count = rightIndex - leftIndex + 1;
            if (count == 2)
            {
                medianeThree.Add(new KeyValuePair<int, int>(rightIndex, inputList[rightIndex]));
                return medianeThree.OrderBy(x => x.Value).Last();
            }

            if ((count) % 2 == 1)//непарне
            {
                medianeThree.Add(new KeyValuePair<int, int>((int)(count / 2), inputList[(int)(count / 2)]));
            }
            else
            {
                medianeThree.Add(new KeyValuePair<int, int>((int)(count / 2) - 1, inputList[(int)(count / 2) - 1]));
            }
            medianeThree.Add(new KeyValuePair<int, int>(rightIndex, inputList[rightIndex]));

            medianeThree.Sort(Compare);

            return medianeThree[1];
            //return rightIndex;
            //return leftIndex;
        }
        private void Swap(List<int> inputList, int i, int j)
        {
            int temp = inputList[i];
            inputList[i] = inputList[j];
            inputList[j] = temp;
        }
        private int Compare(KeyValuePair<int,int> a, KeyValuePair<int, int> b)
        {
            return a.Value.CompareTo(b.Value);
        }
    }
}
