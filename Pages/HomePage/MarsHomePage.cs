using SpecflowTask.Drivers;
using OpenQA.Selenium;

namespace SpecflowTask.Pages.HomePage
{
    public class MarsHomePage : CommonDriver
    {
        private IWebElement mListing;
        private IWebElement dashboard;
        public MarsHomePage()
        {
            mListing=driver.FindElement(By.XPath("//*[@class=\"ui eight item menu\"]/a[3]"));
            dashboard = driver.FindElement(By.XPath("//*[@class=\"ui eight item menu\"]/a[1]"));

        }
        public void manageListingComponentButton()
        {
            MarsWait.WaitToBeClickable("XPath", 10, "//*[@class=\"ui eight item menu\"]/a[3]");
            mListing.Click();

        }
        public void manageDashboardComponentButton()
        {
            MarsWait.WaitToBeClickable("XPath", 10, "//*[@class=\"ui eight item menu\"]/a[1]");
            dashboard.Click();
        }
    }
}
