using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort.Tests
{
    [TestClass()]
    public class QuickSortAlgoritmTests
    {
        [TestMethod()]
        public void PartitionTest()
        {
            //arrange
            List<int> list = new List<int>() { 3, 8, 2, 5, 1, 4, 7, 6 };
            //act
            QuickSortAlgoritm q = new QuickSortAlgoritm();
            list.ForEach((x) => Console.Write(x + " "));
            Console.WriteLine();
            int j = q.Partition(list, 0, list.Count);
            list.ForEach((x) => Console.Write(x + " "));
            Console.WriteLine();
            Console.WriteLine(j);
            //assert
            Assert.Fail();
        }

        [TestMethod()]
        public void QuickSortTest()
        {
            //arrange
            List<int> list = new List<int>() { 3, 8, 2, 5, 1, 4, 7, 6, 12, 10, 9, 11 };
            List<int> list1 = new List<int>(list);
            //act
            QuickSortAlgoritm q = new QuickSortAlgoritm();
            q.QuickSort(list, 0, list.Count - 1);
            //assert
            Assert.AreEqual(list1, list);
        }

        [TestMethod()]
        public void ChoosePivotTest()
        {
            //arrange
            List<int> list = new List<int>() { 3, 8, 2, 5, 1, 4, 7, 6, 12, 10, 9, 11 };
            //act
            QuickSortAlgoritm q = new QuickSortAlgoritm();
            int j = q.ChoosePivot(list, 1, 2).Key;
            //assert
            Assert.AreEqual(j, 2);
        }

        [TestMethod()]
        public void QuickSortTest1()
        {
            List<int> list = new List<int>() { 2, 20, 1, 15, 3, 11, 13, 6, 16, 10, 19, 5, 4, 9, 8, 14, 18, 17, 7, 12 };

            QuickSortAlgoritm q = new QuickSortAlgoritm();
            q.AddOneHandler += Q_AddOneHandler;
            q.QuickSort(list, 0, list.Count - 1);

            Assert.Fail();
        }
        private static void Q_AddOneHandler()
        {
        }
    }
}