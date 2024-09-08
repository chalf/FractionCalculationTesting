using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _74_Hieu_TinhToanPhanSo;
//do đặt tên có chữ số đứng đầu nên nó tự thêm kí tự _ để hợp lệ

namespace _74_Hieu_UnitTest
{
    [TestClass]
    public class UnitTest_74_Hieu
    {
        private PhanSo ps01_74_Hieu, ps02_74_Hieu;
        [TestInitialize] // thiet lap du lieu dung chung cho TC
        public void SetUp()
        {
            ps01_74_Hieu = new PhanSo(1, 2);
            ps02_74_Hieu = new PhanSo(3, 4);
        }

        [TestMethod]
        public void TC1_TestCongPhanSo_74_Hieu()
        {
            // input của TC1 đã thiết lập ở hàm SetUp()
            PhanSo actual;
            PhanSo expected = new PhanSo(5, 4);
            actual = ps01_74_Hieu.cong(ps02_74_Hieu);
            Assert.AreEqual(expected.toString(), actual.toString());
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TC2_TestMauSoBang0_74_Hieu()
        {
            // input của TC2 cần thay đổi mẫu số của ps02 bằng 0, nên gán lại
            ps02_74_Hieu = new PhanSo(3, 0);
            ps01_74_Hieu.cong(ps02_74_Hieu);
        }
    }
}
