using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Heren.Common.Libraries;
using Heren.Common.Libraries.Ftp;

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

        [TestMethod]
        public void TestMethod3()
        {
            //日期判断
            FtpAccess ftpAccess = new FtpAccess();
            ftpAccess.FtpIP = "192.168.1.63";
            ftpAccess.FtpPort = 9000;
            ftpAccess.Password = "medxdb";
            ftpAccess.UserName = "medxdb";
            ftpAccess.FtpMode = FtpMode.PASV;
            ftpAccess.OpenConnection();
            string szLocalFile = @"D:\svn\MDP\MedDoc\2-SourceCode\Trunk\Debug\Documents\Temp\68360_34130_20160513153221_5116.xml";
            string szRemoteFile = "/MEDDOC/68360_34130_20160513153221_5116.xml";
            bool result = ftpAccess.Upload(szLocalFile, szRemoteFile);
            ftpAccess.CloseConnection();
        }

    }
}
