using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Inversion
{
    public static class FileService
    {
        private static string fileName = @"/ListInteger.txt";
        public static List<int> ReadFile()
        {
            List<int> res = new List<int>();

            string[] lines = System.IO.File.ReadAllLines(fileName);
            lines.ToList().ForEach((x) => res.Add(Convert.ToInt32(x)));
            return res;
        }
    }
}
