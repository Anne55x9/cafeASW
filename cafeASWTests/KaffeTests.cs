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

        [TestMethod()]
        public void TestKaffeListe()
        {
            //arrange
            var kaffeListe = new List<Imælk>();
            //Act
            var cortado = new Cortado();
            var latte = new Latte();

            //Disse to kaffer kan tilføjes listen af typen Imælk fordi de implemterer interfaset Imælk. 

            kaffeListe.Add(cortado);
            kaffeListe.Add(latte);

            foreach (var kaf in kaffeListe)
            {
                //Her ses objektet som cortado og derfor kan alle cortado metoder ses.
                if(kaf is Cortado)
                {
                    var kafCord = kaf as Cortado;
                    kafCord.Pris();
                }
                    
                ///Her se objektet via IMælk interfaset og kun metoden mlMælk kan ses. 
                kaf.MlMælk();
            }

            //Assert
            
        }
    }
}