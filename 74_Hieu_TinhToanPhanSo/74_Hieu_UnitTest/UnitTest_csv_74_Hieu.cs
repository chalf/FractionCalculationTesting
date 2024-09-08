using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _74_Hieu_TinhToanPhanSo;

namespace _74_Hieu_UnitTest
{
    [TestClass]
    public class UnitTest_csv_74_Hieu
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\TestData_74_Hieu.csv", "TestData_74_Hieu#csv",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSoure74Hieu()
        {
            int tu1_74_Hieu = int.Parse(TestContext.DataRow[0].ToString());
            int mau1_74_Hieu = int.Parse(TestContext.DataRow[1].ToString());
            int tu2_74_Hieu = int.Parse(TestContext.DataRow[2].ToString());
            int mau2_74_Hieu = int.Parse(TestContext.DataRow[3].ToString());
            string expected = TestContext.DataRow[4].ToString();

            PhanSo ps01 = new PhanSo(tu1_74_Hieu, mau1_74_Hieu);
            PhanSo ps02 = new PhanSo(tu2_74_Hieu, mau2_74_Hieu);
            PhanSo actual = ps01.cong(ps02);
            Assert.AreEqual(expected, actual.toString());
        }
    }
}
