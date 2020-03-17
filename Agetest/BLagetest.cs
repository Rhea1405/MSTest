using System;
using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace Agetest
{
    [TestClass]
    public class BLagetest
    {
        [TestMethod]
        public void greaterthantest()
        {
            DateTime dob = DateTime.Parse("01-01-2008");
            DateTime today = DateTime.Now;
            BLage b = new BLage();
             var expected=Assert.ThrowsException<CustomException>(()=>b.age(dob));
            Assert.AreEqual("Age should be greater than 18", expected.Message);





        }
        [TestMethod]
        public void lessthantest()
        {
            DateTime dob = DateTime.Parse("01-01-1770");
            DateTime today = DateTime.Now;
            BLage b = new BLage();
            var expected = Assert.ThrowsException<CustomException>(() => b.age(dob));
            Assert.AreEqual("Age should be less than 60", expected.Message);





        }

        [TestMethod]
        public void correct()
        {
            DateTime dob = DateTime.Parse("05-14-1997");
            BLage B = new BLage();
         string expected = "22";
            string actual = B.age(dob);
            Assert.AreEqual(expected, actual);


        }
    }
}
