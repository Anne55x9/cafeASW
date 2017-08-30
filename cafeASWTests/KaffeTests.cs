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
    public class KaffeTests
    {
        [TestMethod()]
        public void PrisTestKaffe()
        {
            //arrange
            var kaffe = new SortKaffe();
            //Act
            int pris = kaffe.Pris();
            //Assert
            Assert.AreEqual(20, pris);
        }

        [TestMethod()]
        public void StyrkeTestKaffe()
        {
            //arrange
            var kaffe = new SortKaffe();
            //Act
            string styrke = kaffe.Styrke();
            //Assert
            Assert.AreEqual("Stærk.", styrke);
        }
    }
}