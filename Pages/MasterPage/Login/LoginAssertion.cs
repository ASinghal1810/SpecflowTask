﻿
using SpecflowTask.Drivers;
using Newtonsoft.Json;
using OpenQA.Selenium;

namespace SpecflowTask.Pages.MasterPage.Login
{
    public class ProfileAssertion : CommonDriver
    {
        private static IWebElement LogoutText => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button"));
        //private static string NotificationXPath => "/html/body/div[1]";
        //private static IWebElement NotificationText => driver.FindElement(By.XPath("/html/body/div[1]"));
        //private static IWebElement CloseHower => driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[3]"));
        private static IWebElement Logout => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button"));


        public void assertLogin(int i)
        {
            string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\New folder (2)\MarsAdvancedTask\MarsAdvancedTask\DataFiles\TestData.json");
            Users users = JsonConvert.DeserializeObject<Users>(dataJson);
            User user = users.users.ElementAt(i);
            Thread.Sleep(5000);
            try
            {


                if (LogoutText.Text == "Sign Out")
                {

                    if (user.ExpectedResult == "Success")
                    {
                        i++;
                        Console.WriteLine("Test 1." + i + " is Successfull");
                        Logout.Click();
                    }
                    else
                    {
                        i++;
                        Console.WriteLine("Test 1.", i, " is Unsuccessfull");
                        Logout.Click();
                    }

                }
            }
            catch (NoSuchElementException)
            {
                if (user.ExpectedResult == "Success")
                {
                    i++;
                    Console.WriteLine("Test 1." + i + " is Unsuccessfull");
                    driver.Navigate().Refresh();
                }
                else
                {
                    i++;
                    Console.WriteLine("Test 1." + i + " is Successfull");
                    driver.Navigate().Refresh();
                }


            }

        }
    }
}
