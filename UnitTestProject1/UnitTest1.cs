using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoviesAssessment;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Form1 myForm1 = new Form1();
        Data myData = new Data();

        [TestMethod]
        public void TestConnectionString()
        {
            int Actual = Convert.ToInt32(myData.ReturnCountofCustomers());
            Assert.IsTrue(Actual > 1);
        }

        [TestMethod]
        public void TestCountOfMoviesRented()
        {
            int Actual = Convert.ToInt32(myData.ReturnCountofMoviesRented());
            Assert.IsTrue(Actual > 20);

        }
    }
}
