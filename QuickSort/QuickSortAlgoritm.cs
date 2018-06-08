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
        public int Partition(List<int> inputList, int leftIndex,int rightIndex)
        {
            int p = inputList[leftIndex];
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

            int i = ChoosePivot(inputList, leftIndex, rightIndex);
            Swap(inputList, leftIndex, i);

            int j = Partition(inputList, leftIndex, rightIndex);
            QuickSort(inputList, leftIndex, j - 1);
            QuickSort(inputList, j + 1, rightIndex);
        }

        public int ChoosePivot(List<int> inputList, int leftIndex,int rightIndex)
        {
            List<int> medianeThree = new List<int>();
            medianeThree.Add(inputList[leftIndex]);

            int count = rightIndex - leftIndex + 1;
            if ((count) % 2 == 1)//непарне
            {
                medianeThree.Add(inputList[(int)(count / 2)]);
            }
            else
            {
                medianeThree.Add(inputList[(int)(count / 2)-1]);
            }
            medianeThree.Add(inputList[rightIndex]);

            medianeThree.Sort();

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
    }
}
