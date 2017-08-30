using Microsoft.VisualStudio.TestTools.UnitTesting;
using cafeASW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeASW.Tests
{
    [TestClass()]
    public class SortKaffeTests
    {
        [TestMethod()]

        [ExpectedException(typeof(ArgumentException))]
        public void PrisTestPåRabatSortKaffe()
        {
            //Arrange

            var sortkaffe = new SortKaffe(20);

            //Act

            int pris = sortkaffe.Pris();

            //Assert


        }

        [TestMethod()]

        [ExpectedException(typeof(ArgumentException))]
        public void PrisTestPåRabatSortKaffe21kr()
        {
            //Arrange

            var sortkaffe = new SortKaffe(21);

            //Act

            int pris = sortkaffe.Pris();

            //Assert


        }
    }
}