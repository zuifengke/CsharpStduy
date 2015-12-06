using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Heren.Common.Libraries;
namespace CshorpStudy.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //日期判断
            DateTime dt = new DateTime();
            bool result = DateTime.TryParse("2008年6月9日 05:12", out dt);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //日期判断
            DateTime dt = new DateTime();
            string s = "2008年6月9日 05:12";
            bool result = GlobalMethods.Convert.StringToDate(s, ref dt);
        }
    }
}
