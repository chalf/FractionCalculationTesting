using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;


namespace _74_Hieu_UnitTest
{
    [TestClass]
    public class WebDriver_AddToBasket_74_Hieu
    {
        [TestMethod]
        public void AddToBasket_74_Hieu()
        {
            IWebDriver driver_74_Hieu = new ChromeDriver();
            driver_74_Hieu.Navigate().GoToUrl("https://practice.automationtesting.in/");

            //lấy bằng Css Selector
            IWebElement Search = driver_74_Hieu.FindElement(By.CssSelector("#s"));
            // nhập từ khóa tìm kiếm
            Search.SendKeys("javascript");
            Thread.Sleep(2000);

            // enter
            Search.SendKeys(Keys.Enter);
            Thread.Sleep(3000);

            // element kết quả tìm kiếm
            driver_74_Hieu.FindElement(By.XPath("//*[@id=\"post-165\"]/div/div/h2/a")).Click();

            Thread.Sleep(3000);
            // thêm vào giỏ hàng (lấy bằng classname)
            driver_74_Hieu.FindElement(By.ClassName("single_add_to_cart_button")).Click();

            Thread.Sleep(3000);
            //xem giỏ hàng
            driver_74_Hieu.FindElement(By.CssSelector("#wpmenucartli > a")).Click();
            Thread.Sleep(3000);
            driver_74_Hieu.Close();
        }
    }
}
