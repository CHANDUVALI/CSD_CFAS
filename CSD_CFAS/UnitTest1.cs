using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace CSD_CFAS
{
    [TestFixture]
    public class UnitTest1
    {
        string Url = "http://172.16.18.106/CFAS_Selenium/";

        [Test]
        public void A_SingleVoucherPayment()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("Label2")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("fasu1");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("mubop@123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t6")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch"))).SelectByText("GATHM");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSearch"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSearch")).Click();
            Task.Delay(2000).Wait();

            var element6 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEdit_0"));
            var script6 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js6 = (IJavaScriptExecutor)driver;
            js6.ExecuteScript(script6, element6);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEdit_0")).Click();
            Task.Delay(2000).Wait();

            var element2 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_PaymentList_refNo_0"));
            var script2 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js2 = (IJavaScriptExecutor)driver;
            js2.ExecuteScript(script2, element2);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_PaymentList_refNo_0")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_PaymentList_refNo_0")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_PaymentList_refNo_0")).SendKeys("9");
            Task.Delay(2000).Wait();

            var element3 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_PaymentList_refNo_0"));
            var script3 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js3 = (IJavaScriptExecutor)driver;
            js3.ExecuteScript(script3, element3);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_PaymentList_narration_0")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_PaymentList_narration_0")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_PaymentList_narration_0")).SendKeys("test9");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.Close();

        }

        [Test]
        public void B_MultipleVoucherPayment()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("Label2")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("fasu1");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("mubop@123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t5")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch"))).SelectByText("GATHM");
            Task.Delay(2000).Wait();

            var element6 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1"));
            var script6 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js6 = (IJavaScriptExecutor)driver;
            js6.ExecuteScript(script6, element6);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.FindElement(By.Id("GridView_Vendor_Label2_1")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();


            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSearch"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSearch")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_checkCancel_0")).Click();
            Task.Delay(1000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_checkCancel_1")).Click();

            var element2 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_refNo"));
            var script2 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js2 = (IJavaScriptExecutor)driver;
            js2.ExecuteScript(script2, element2);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_refNo")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_refNo")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_refNo")).SendKeys("98");
            Task.Delay(2000).Wait();

            var element3 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_narration"));
            var script3 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js3 = (IJavaScriptExecutor)driver;
            js3.ExecuteScript(script3, element3);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_narration")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_narration")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_narration")).SendKeys("testtest");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.Close();

        }

        [Test]
        public void C_TDSExport()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("Label2")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("fasu1");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("mubop@123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t9")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch"))).SelectByText("GATHM");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_fyear")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_fyear"))).SelectByText("2019");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlmonth")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlmonth"))).SelectByText("3");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Submit"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Submit")).Click();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.Close();

        }

        [Test]
        public void D_TDSManage()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("Label2")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("fasu1");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("mubop@123");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t10")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_RadioButtonList1_1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_busUnit")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_busUnit"))).SelectByText("GATHM");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_month")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_month"))).SelectByText("2");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_fyear")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_fyear"))).SelectByText("2019");
            Task.Delay(2000).Wait();

            IWebElement selectDate = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_accdates"));
            selectDate.Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextBox2_CalendarExtender_today")).Click();
            Task.Delay(5000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_accnt")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_accnt"))).SelectByText("2206004");
            Task.Delay(2000).Wait();

            var element6 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button2"));
            var script6 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js6 = (IJavaScriptExecutor)driver;
            js6.ExecuteScript(script6, element6);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button2")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.FindElement(By.Id("GridView_Vendor_Label2_1")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Task.Delay(2000).Wait();

        }
    }
}
