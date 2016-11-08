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
            return unsorted;
        }
    }
}
