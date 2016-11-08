using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string[]> unsorted = new List<string[]> {
                new string[] { "Мельбурн", "Кельн" },
                new string[] { "Москва", "Париж" },
                new string[] { "Кельн", "Москва" }};
            List<string[]> sorted = Sorter.Sort(unsorted);
        }



    }

    public class Sorter
    {
        public static List<string[]> Sort(List<string[]> unsorted)
        {
            if (null == unsorted)
                throw new ArgumentException("unsorted");

            //create search hashes for start and end points
            Dictionary<string, int> hashA = new Dictionary<string, int>();
            HashSet<string> hashB = new HashSet<string>();
            for (int i = 0; i < unsorted.Count; i++)
            {
                hashA[unsorted[i][0]] = i; // N*O(1)
                hashB.Add(unsorted[i][1]); // N*O(1)
            }
            int idx = -1;
            //search start point
            for (int i = 0; i < unsorted.Count; i++)
            {
                if (!hashB.Contains(unsorted[i][0])) // N*O(1)
                {
                    idx = i;
                    break;
                }
            }
            List<string[]> sorted = new List<string[]>(unsorted.Count);
            for (int i = 0; i < unsorted.Count; i++)
            {
                sorted.Add(unsorted[idx]); // N*O(1)
                if (i < unsorted.Count-1) // cause last destination point is not in hashA
                    idx = hashA[unsorted[idx][1]]; // N*O(1)
            }
            return sorted;
            // overall complexity O(N)
        }
    }
}
