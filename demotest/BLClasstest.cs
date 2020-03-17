using System;
using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace demotest
{
    [TestClass]
    public class BLClasstest
    {
        [TestMethod]
        public void Dividetest1()
        {

            //arrange-declare actuals and expected
            int num = 10;
            int deno = 2;
            int expected = 5;
            int actual = 0;

            //act-call the method and pass the actuals as parameters
            BLclass b = new BLclass();
            actual = b.divide(num.ToString(), deno.ToString());

            //assert-check whether actuals are matching with expected

            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void Dividetest2()
        {
            int num = 0;
            int deno = 2;
            int expected = 0;



            BLclass b = new BLclass();
            int actual = b.divide(num.ToString(), deno.ToString());

            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void dividetest3()
        {
            int num = 10;
            int deno = 0;
            BLclass b = new BLclass();
            var expected = Assert.ThrowsException<DivideByZeroException>(()=>b.divide(num.ToString(),deno.ToString()));
            Assert.AreEqual("cannot divide by 0",expected.Message);




        }
        [TestMethod]
        public void dividetest4()
        {
           
            BLclass b = new BLclass();
            var expected = Assert.ThrowsException<FormatException>(() => b.divide("abc", "xyz"));
            Assert.AreEqual("Only Numbers", expected.Message);




        }
    }
}
