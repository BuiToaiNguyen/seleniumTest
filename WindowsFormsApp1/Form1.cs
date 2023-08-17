using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using AutoIt;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static IWebDriver driver;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                ChromeOptions options = new ChromeOptions();
                options.AddArguments("--disable-extensions"); // to disable extension
                options.AddArguments("--disable-notifications"); // to disable notification
                options.AddArguments("--disable-application-cache"); // to disable cache
                options.BinaryLocation = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
                driver = new ChromeDriver(options);
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)); // 10 là thời gian chờ tối đa (giây)
                driver.Navigate().GoToUrl("https://www.facebook.com/");
                IWebElement ele = driver.FindElement(By.Id("email"));
                IWebElement element = wait.Until(ExpectedConditions.ElementExists(By.Id("email")));
                element.SendKeys("0583504807");
                /*  Console.Write("username value is entered \n");*/
                IWebElement ele1 = driver.FindElement(By.Name("pass"));
                IWebElement element2 = wait.Until(ExpectedConditions.ElementExists(By.Name("pass")));
                //enter the password value  
                element2.SendKeys("10102000!n");
                /*  Console.Write("password is entered");*/
                IWebElement element3 = wait.Until(ExpectedConditions.ElementExists((By.CssSelector("button[class='_42ft _4jy0 _6lth _4jy6 _4jy1 selected _51sy']"))));
                element3.Click();

                IWebElement element4 = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("a[aria-label='Trang chủ']")));
                element4.Click();

                IWebElement element5 = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("div[class='x1i10hfl x6umtig x1b1mbwd xaqea5y xav7gou x9f619 x1ypdohk xe8uvvx xdj266r x11i5rnm xat24cr x1mh8g0r x16tdsg8 x1hl2dhg xggy1nq x87ps6o x1lku1pv x1a2a7pz x6s0dn4 xmjcpbm x107yiy2 xv8uw2v x1tfwpuw x2g32xy x78zum5 x1q0g3np x1iyjqo2 x1nhvcw1 x1n2onr6 xt7dq6l x1ba4aug x1y1aw1k xn6708d xwib8y2 x1ye3gou']")));
                element5.Click();

   
                //change permisson
                IWebElement element6 = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("div[class='x1qhmfi1 xhk9q7s x1otrzb0 x1i1ezom x1o6z2jb xurb0ha x1sxyh0 x1iorvi4 xjkvuk6 x1a2a7pz']")));

                if (element6 != null)
                {
                    element6.Click();

                    IWebElement element10 = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("div[class='x1a2a7pz x1oo3vh0 x1rdy4ex']")));
                    Thread.Sleep(1000);
                    var element11 = element10.FindElements(By.CssSelector("div[data-visualcompletion='ignore-dynamic']"))[0];
                    element11.Click();

                    IWebElement element7 = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("div[aria-label='Xong']")));
                    element7.Click();
                }

                // thêm màu
                //IWebElement eleColor = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("div[aria-label='Hiển thị các tùy chọn phông nền']"))); 
                //if(eleColor != null)
                //{
                //    eleColor.Click();
                //    IWebElement eleTim = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("div[aria-label='Tím thẫm, phông nền']")));
                //    eleTim.Click();


                //}
                // thêm ảnh
                IWebElement eleImage = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("div[class='xr9ek0c xfs2ol5 xjpr12u x12mruv9']")));
                eleImage.Click();                   
                
     
                    IWebElement eleUpload = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("div[class='x9f619 x1n2onr6 x1ja2u2z x78zum5 xdt5ytf x2lah0s x193iq5w x6s0dn4 x1gslohp x12nagc xzboxd6 x14l7nz5']")));
                eleUpload.Click();


                

                
                IWebElement eleSelectImage = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("input[class='x1s85apg']")));
                //IWebElement eleSelect Image = wait.Until(ExpectedConditions.ElementExists(By.XPath("//input[@type='file']")));

                //eleSelectImage.SendKeys(@"D:\Nguyen\selenium\seleniumTest\WindowsFormsApp1\photo_2023-07-20_14-01-29.jpg");




                // create status

                IWebElement element8 = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("p[class='xdj266r x11i5rnm xat24cr x1mh8g0r x16tdsg8']")));


                if (element8 != null)
                {
                    element8.SendKeys("Minh yêu Sang lắm đóng nha" + Guid.NewGuid());
                    var eleDang = driver.FindElement(By.CssSelector("div[aria-label='Đăng']"));
                    IWebElement element9 = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("div[aria-label='Đăng']")));

                    if (element9 != null)
                    {
                        element9.Click();
                    }


                }

            }
            catch (Exception ex)
            {

            }
            finally
            {

            }





        }
    }
}
