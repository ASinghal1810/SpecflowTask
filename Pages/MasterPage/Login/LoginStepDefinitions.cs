
using TechTalk.SpecFlow;
using SpecflowTask.Drivers;
using OpenQA.Selenium.Chrome;
using Newtonsoft.Json;

namespace SpecflowTask.Pages.MasterPage.Login
{

    [Binding]
    public class LoginStepDefinitions : CommonDriver
    {

        MarsMasterPage MasterPageObj;
        LoginMethods LoginMethodObj;
        public LoginStepDefinitions()
        {
            MasterPageObj = new MarsMasterPage();
            LoginMethodObj = new LoginMethods();
            //ProFileAssertObj = new ProfileAssertion();

        }

        [Given(@"I logged into portal successfully")]
        public void GivenILoggedIntoPortalSuccessfully()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }

        [When(@"I click on Sign In Button")]
        public void WhenIClickOnSignInButton()
        {
            MasterPageObj.MarsMasterPageNavigateToSignInForm();
        }

        [When(@"Type in Valid Credentials")]
        public void WhenTypeInValidCredentials()
        {
            string dataJson = File.ReadAllText(@"C:\Users\ankur\Desktop\MarsSpecflow\SpecflowTask\DataFiles\TestData.json");
            Users users = JsonConvert.DeserializeObject<Users>(dataJson);
            User user = users.users.ElementAt(0);
            MasterPageObj.MarsMasterPageLoginUser(LoginMethodObj.userUsername(0), LoginMethodObj.userPassword(0));
        }

        [Then(@"User is logged in Successfully")]
        public void ThenUserIsLoggedInSuccessfully()
        {
            Console.WriteLine("Pass");
        }
    }
}
