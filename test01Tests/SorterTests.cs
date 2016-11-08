using Microsoft.VisualStudio.TestTools.UnitTesting;
using test01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test01.Tests
{
    [TestClass()]
    public class SorterTests
    {
        [TestMethod()]
        public void SortTest()
        {
            try
            {
                Sorter.Sort(null);
                Assert.Fail("Should throw Argument Exception");
            }
            catch (ArgumentException ex)
            {

            }

        }
        [TestMethod()]
        public void Test01()
        {
            try
            {
                var res = Sorter.Sort(new List<string[]>());
                Assert.IsNotNull(res);
                Assert.IsTrue(res.Count == 0);
            }
            catch (ArgumentException ex)
            {
                Assert.Fail("Should not throw Argument Exception");
            }
        }
        [TestMethod()]
        public void SortTest02()
        {
            List<string[]> unsorted = new List<string[]> {
                new string[] { "Мельбурн", "Кельн" },
                new string[] { "Москва", "Париж" },
                new string[] { "Кельн", "Москва" }};
            List<string[]> sorted = Sorter.Sort(unsorted);
            Assert.IsTrue(sorted.Count == 3);
            Assert.IsTrue(sorted[0][0] == "Мельбурн");
            Assert.IsTrue(sorted[1][0] == "Кельн");
            Assert.IsTrue(sorted[2][0] == "Москва");
        }
    }
}