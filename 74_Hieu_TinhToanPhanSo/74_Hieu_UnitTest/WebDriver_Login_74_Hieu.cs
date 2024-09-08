using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading; // để sử dụng Thread.Sleep() dừng lại 1 chút để kịp theo dõi Running Test


namespace _74_Hieu_UnitTest
{
    [TestClass]
    public class WebDriver_Login_74_Hieu
    {
        IWebDriver driver_74_Hieu;
        IWebElement element_MyAccount, element_Username, element_password, element_Login;
        [TestInitialize] // thiet lap du lieu dung chung cho TC
        public void SetUp()
        {
            // tạo driver
            driver_74_Hieu = new ChromeDriver();
            // gán trang cần navigate
            driver_74_Hieu.Url = "https://practice.automationtesting.in/";
            element_MyAccount = driver_74_Hieu.FindElement(By.LinkText("My Account"));
        }
        [TestMethod]
        public void LoginFail_TC1_74_Hieu()
        {
            // truy cập trang web
            //Cách 1: driver_74_Hieu.Navigate().GoToUrl("https://practice.automationtesting.in/");
            driver_74_Hieu.Navigate();

            // Click vào MyAccount
            element_MyAccount.Click();
            Thread.Sleep(1500);

            //Click đăng nhập (username và password trống)
            //lấy element bằng name
            element_Login = driver_74_Hieu.FindElement(By.Name("login"));
            element_Login.Click();
            Thread.Sleep(3000);
            driver_74_Hieu.Close();
        }
        [TestMethod]
        public void LoginFail_TC2_74_Hieu()
        {
            driver_74_Hieu.Navigate();
            // Click vào MyAccount
            element_MyAccount.Click();
            Thread.Sleep(1500);

            //lấy element bằng XPath
            element_Username = driver_74_Hieu.FindElement(By.XPath("//*[@id=\"username\"]"));
            //Nhập username sai, password trống
            element_Username.SendKeys("jhgga55k_74_Hieu");
            Thread.Sleep(1500);
            //lấy element bằng name
            element_Login = driver_74_Hieu.FindElement(By.Name("login"));
            element_Login.Click();

            Thread.Sleep(3000);
            driver_74_Hieu.Close();
        }
        [TestMethod]
        public void LoginFail_TC3_74_Hieu()
        {
            driver_74_Hieu.Navigate();
            // Click vào MyAccount
            element_MyAccount.Click();
            Thread.Sleep(1500);

            //lấy element bằng XPath
            element_Username = driver_74_Hieu.FindElement(By.XPath("//*[@id=\"username\"]"));
            //lấy element bằng id
            element_password = driver_74_Hieu.FindElement(By.Id("password"));
            //Nhập username sai, password sai
            element_Username.SendKeys("jhgga55k_74_Hieu");
            element_password.SendKeys("65af5g5g5_74_Hieu");
            Thread.Sleep(1500);

            //lấy element bằng name
            element_Login = driver_74_Hieu.FindElement(By.Name("login"));
            element_Login.Click();

            Thread.Sleep(3000);
            driver_74_Hieu.Close();
        }
        [TestMethod]
        public void LoginFail_TC4_74_Hieu()
        {
            driver_74_Hieu.Navigate();
            // Click vào MyAccount
            element_MyAccount.Click();
            Thread.Sleep(1500);

            //lấy element bằng XPath
            element_Username = driver_74_Hieu.FindElement(By.XPath("//*[@id=\"username\"]"));
            //lấy element bằng id
            element_password = driver_74_Hieu.FindElement(By.Id("password"));
            //Nhập username đúng, password sai
            element_Username.SendKeys("2151053018hieu");
            element_password.SendKeys("65af5g5g5_74_Hieu");
            Thread.Sleep(1500);

            //lấy element bằng name
            element_Login = driver_74_Hieu.FindElement(By.Name("login"));
            element_Login.Click();

            Thread.Sleep(3000);
            driver_74_Hieu.Close();
        }
        [TestMethod]
        public void TC5_Success_74_Hieu()
        {
            driver_74_Hieu.Navigate();
            // Click vào MyAccount
            element_MyAccount.Click();
            Thread.Sleep(1500);

            //lấy element bằng XPath
            element_Username = driver_74_Hieu.FindElement(By.XPath("//*[@id=\"username\"]"));
            //lấy element bằng id
            element_password = driver_74_Hieu.FindElement(By.Id("password"));
            //Nhập username đúng, password đúng
            element_Username.SendKeys("2151053018hieu");
            element_password.SendKeys("H!eu123456#");
            Thread.Sleep(1500);

            //lấy element bằng name
            element_Login = driver_74_Hieu.FindElement(By.Name("login"));
            element_Login.Click();

            Thread.Sleep(3000);
            driver_74_Hieu.Close();
        }
    }
}
