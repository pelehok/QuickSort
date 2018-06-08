using Counting_Inversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = FileService.ReadFile();
            List<int> list1 = new List<int>(list);
            //act
            QuickSortAlgoritm q = new QuickSortAlgoritm();
            q.QuickSort(list, 0, list.Count - 1);
            list.ForEach((x) => Console.Write(x + " "));
            Console.ReadKey();
        }
    }
}
